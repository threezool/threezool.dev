using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Moq;
using Threezool.dev.Data.Models;
using Threezool.dev.Data.Repository;

namespace Threezool.dev.Test.MockDataAccess
{
    internal class MockRepository<T> where T : BaseEntity
    {
        internal static List<T> MockTable { get; private set; }

        public static IRepository<T> GetMockObject(List<T> mockTable)
        {
            MockTable = mockTable;
            
            var mockRepository = new Mock<IRepository<T>>();
            
            mockRepository.Setup(r => r.GetAll()).Returns(() =>
            {
                CheckIfDbISSet();

                return MockTable.AsQueryable();
            });
            
            mockRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns<int>(id =>
            {
                CheckIfDbISSet();

                return MockTable.FirstOrDefault(e => e.Id == id);
            });

            mockRepository.Setup(x => x.FindByCondition(It.IsAny<Expression<Func<T, bool>>>()))
                .Returns<Expression<Func<T, bool>>>(predicate =>
                {
                    CheckIfDbISSet();
                    
                    return MockTable.Where(predicate.Compile()).AsQueryable();
                });
            
            mockRepository.Setup(x => x.Create(It.IsAny<T>()))
                .Returns<T>(newEntity =>
                {
                    CheckIfDbISSet();
                    
                    newEntity.Id = MockTable.Max(e => e.Id) + 1;
                    
                    MockTable.Add(newEntity);
                    
                    return 1;
                });
            
            mockRepository.Setup(x => x.Update(It.IsAny<T>()))
                .Returns<T>(updatedEntity =>
                {
                    CheckIfDbISSet();
                    
                    int index = MockTable.FindIndex(m => m.Id == updatedEntity.Id);
                    
                    if(index >= 0)
                        MockTable[index] = updatedEntity;
                    
                    return 1;
                });
            
            mockRepository.Setup(x => x.Delete(It.IsAny<T>()))
                .Callback<T>(entityToDelete =>
                {
                    CheckIfDbISSet();
                    
                    int index = MockTable.FindIndex(m => m.Id == entityToDelete.Id);
                    
                    if(index >= 0)
                        MockTable.RemoveAt(index);
                });
            
            return mockRepository.Object;
        }

        private static void CheckIfDbISSet()
        {
            if (MockTable == null || MockTable.Count == 0)
                throw new Exception("MockDb needs to be set before calling the mock repository");
        }
    }
}
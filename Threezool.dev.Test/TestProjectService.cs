using Moq;
using NUnit.Framework;
using Threezool.dev.Data.Models;
using Threezool.dev.Data.Seed;
using Threezool.dev.Services;
using Threezool.dev.Test.MockDataAccess;

namespace Threezool.dev.Test
{
    public class TestProjectService
    {
        private IProjectService projectService;
        
        [SetUp]
        public void Setup()
        {
            var mockProjectRepository = MockRepository<Project>.GetMockObject(ProjectSeed.GetProjectSeedData());
            
            this.projectService = new ProjectService(mockProjectRepository);
        }

        [Test]
        public void TestFetchingAllProjectsFromService()
        {
            var allProjects = projectService.GetAllProjects();
            
            Assert.Greater(allProjects.Count, 0);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Threezool.dev.Data.Repository;
using Threezool.dev.Models;

namespace Threezool.dev.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IGenericRepository<Project> projectRepository;

        public ProjectService(IGenericRepository<Project> projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public List<Project> GetAllProjects()
        {
            return projectRepository.GetAll().ToList();
        }
    }
}
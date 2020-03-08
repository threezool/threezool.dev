using System.Collections.Generic;
using System.Linq;
using Threezool.dev.Data.Repository;
using Threezool.dev.Models;

namespace Threezool.dev.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> projectRepository;

        public ProjectService(IRepository<Project> projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public List<Project> GetAllProjects()
        {
            return projectRepository.GetAll().ToList();
        }
    }
}
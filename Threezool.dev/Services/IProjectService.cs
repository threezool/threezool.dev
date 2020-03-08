using System.Collections.Generic;
using Threezool.dev.Models;

namespace Threezool.dev.Services
{
    public interface IProjectService
    {
        List<Project> GetAllProjects();
    }
}
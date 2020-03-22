using System.Collections.Generic;
using Threezool.dev.Data.Models;

namespace Threezool.dev.Services
{
    public interface IProjectService
    {
        List<Project> GetAllProjects();
    }
}
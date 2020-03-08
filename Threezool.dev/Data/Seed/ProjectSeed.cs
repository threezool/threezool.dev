using System;
using System.Collections.Generic;
using Threezool.dev.Models;

namespace Threezool.dev.Data.Seed
{
    public static class ProjectSeed
    {
        public static List<Project> GetProjectSeedData()
        {
            return new List<Project>
            {
                new Project(1, "Savely1", "", "", "", new DateTime(), new DateTime()),
                new Project(2, "Savely2", "", "", "", new DateTime(), new DateTime()),
                new Project(3, "Savely3", "", "", "", new DateTime(), new DateTime()),
                new Project(4, "Savely4", "", "", "", new DateTime(), new DateTime()),
                new Project(5, "Savely5", "", "", "", new DateTime(), new DateTime()),
            };
        }
    }
}
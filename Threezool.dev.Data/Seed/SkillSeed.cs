using System.Collections.Generic;
using Threezool.dev.Data.Models;

namespace Threezool.dev.Data.Seed
{
    public static class SkillSeed
    {
        public static List<Skill> GetProjectSeedData()
        {
            return new List<Skill>
            {
                new Skill(1, "C#"),
                new Skill(2, ".Net"),
                new Skill(3, ".Net Core"),
                new Skill(4, "Xamarin Native"),
                new Skill(5, "Xamarin Forms"),
            };
        }
    }
}
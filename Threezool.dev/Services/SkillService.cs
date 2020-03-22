using System.Collections.Generic;
using Threezool.dev.Data.Models;
using Threezool.dev.Data.Repository;

namespace Threezool.dev.Services
{
    public class SkillService : ISkillService
    {
        private readonly IRepository<Skill> skillsRepository;

        public SkillService(IRepository<Skill> skillsRepository)
        {
            this.skillsRepository = skillsRepository;
        }
    }
}
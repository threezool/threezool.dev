using System.Collections.Generic;
using Threezool.dev.Data.Repository;
using Threezool.dev.Models;

namespace Threezool.dev.Services
{
    public class SkillService : ISkillService
    {
        private readonly Repository<Skill> skillsRepository;

        public SkillService(Repository<Skill> skillsRepository)
        {
            this.skillsRepository = skillsRepository;
        }
    }
}
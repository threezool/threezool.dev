using System.Collections.Generic;
using Threezool.dev.Data.Repository;
using Threezool.dev.Models;

namespace Threezool.dev.Services
{
    public class SkillService : ISkillService
    {
        private readonly GenericRepository<Skill> skillsRepository;

        public SkillService(GenericRepository<Skill> skillsRepository)
        {
            this.skillsRepository = skillsRepository;
        }
    }
}
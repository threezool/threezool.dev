namespace Threezool.dev.Data.Models
{
    public class Skill : BaseEntity
    {
        public string Name { get; set; }
        
        public Skill(int id) : base(id)
        {
            
        }

        public Skill(int id, string name) : base(id)
        {
            this.Name = name;
        }
    }
}
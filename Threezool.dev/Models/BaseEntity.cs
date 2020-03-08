namespace Threezool.dev.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity(int id = 0)
        {
            this.Id = id;
        }
    }
}
namespace Threezool.dev.Data.Models
{
    public enum ContactType
    {
        Private,
        Consultant
    }
    
    public class Contact : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ContactType ContactType { get; set; }
    }
}
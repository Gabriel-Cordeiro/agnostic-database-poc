namespace Core.Entities
{
    public class User : BaseEntity
    {
        public User(int id, string name, string email, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Email = email;
            CreatedAt = createdAt;
        }

        private User() { }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Test {get; set;}   

        public virtual ICollection<Address> Addresses { get; set; }
    }
}

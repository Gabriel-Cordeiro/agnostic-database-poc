namespace Core.Entities
{
    public class Address : BaseEntity
    {
        public Address(int id, string street, int number, User user, DateTime createdAt)
        {
            Id = id;
            Street = street;
            Number = number;
            User = user;
            CreatedAt = createdAt;
        }

        private Address() { }

        public string Street { get; set; }

        public int Number { get; set; }

        public virtual User User { get; set; }
    }
}

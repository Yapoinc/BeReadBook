using System;

namespace Model.Database
{
    public class Person
    {
        public int Id { get; set; }
        public string Guid { get; set; } = (new Guid()).ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string ImageUrl { get; set; }
        public int AddressId { get; set; }
    }
}

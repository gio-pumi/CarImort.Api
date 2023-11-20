using System.ComponentModel.DataAnnotations;

namespace CarImport.Domain.DbEntities
{
    public class Customer: CommonFields
    {
        [MaxLength(11)]
        public string PersonalNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Order> Orders { get; set; }
    }
}

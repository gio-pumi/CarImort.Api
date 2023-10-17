namespace CarImport.Domain.DbEntities
{
    public class Customer: CommonFields
    {
        public int ID { get; set; }
        public string CusomerID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

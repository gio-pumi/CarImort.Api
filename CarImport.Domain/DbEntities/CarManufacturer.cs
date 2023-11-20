namespace CarImport.Domain.DbEntities
{
    public class CarManufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarModel> CarModels { get; set; }
    }
}
 
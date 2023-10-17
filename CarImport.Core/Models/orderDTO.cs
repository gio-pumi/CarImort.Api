using CarImport.Infrastructure.Helper;

namespace CarImport.Core.Models
{
    public class orderDTO
    {
        public int ID { get; set; }
        public string OrderName { get; set; }

        public Status Status { get; set; }

        public decimal CarCost { get; set; }

     //   public Currecy Currecy{ get; set; }

        public string Details { get; set; }

    }
}

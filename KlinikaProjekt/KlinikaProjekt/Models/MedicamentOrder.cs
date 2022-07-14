using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KlinikaProjekt.Models
{
    public class MedicamentOrder
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string shippingAdress { get; set; }
        public int quantity { get; set; }
        public string note { get; set; }
        public string orderDate { get; set; }
    }
}

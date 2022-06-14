using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KlinikaProjekt.Models
{
    public class Contact
    {

        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string email { get; set; }

        [Required]
        public int phoneNumber { get; set; }
        [Required]
        public string message { get; set; }

    }
}

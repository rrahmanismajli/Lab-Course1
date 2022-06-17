using System.ComponentModel.DataAnnotations;

namespace KlinikaProjekt.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Upload Your Image URL of Review Post")]
        public string image { get; set; }
        [Required]
        [Display(Name = "Write your Review")]
        public string reviewText { get; set; }
        [Display(Name = "Your Name")]
        public string fullname { get; set; }




    }
}

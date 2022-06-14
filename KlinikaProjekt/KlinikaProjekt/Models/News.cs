using System;
using System.ComponentModel.DataAnnotations;

namespace KlinikaProjekt.Models
{
    public class News
    {

        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name ="Image Banner")]
        public string image { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string title { get; set; }
        [Required]
        [Display(Name = "Descripiton")]
        public string desc { get; set; }
        [Required]
      [Display(Name = "Date/Time")]
        public DateTime datetime { get; set; }


    }
}

using KlinikaProjekt.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Models
{
    public class Department:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Department Logo")]
        [Required(ErrorMessage = "Department logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Department name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Department description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Training> MTraining { get; set; }
    }
}

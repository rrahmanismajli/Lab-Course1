using KlinikaProjekt.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace KlinikaProjekt.Models
{
    public class Appointment
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name ="Full Name")]
        public string Name { get; set; }

        public int number { get; set; }
        public string email { get; set; }

        public string  adress { get; set; }

        public System.DateTime AppointmentDate { get; set; }
          public Trainingategory TrainingCategory { get; set; }


}
}

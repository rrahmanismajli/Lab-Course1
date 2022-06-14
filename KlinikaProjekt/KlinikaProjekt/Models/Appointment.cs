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
        [Display(Name = "Your Phone Number")]
        public int number { get; set; }
        [Display(Name = "Your E-mail")]
        public string email { get; set; }
        [Display(Name = "Your Adress")]
        public string  adress { get; set; }
        [Display(Name = "Appoointment Date/Time")]
        public System.DateTime AppointmentDate { get; set; }
        [Display(Name = "Department")]
        public Trainingategory TrainingCategory { get; set; }


}
}

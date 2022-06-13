using KlinikaProjekt.Data;
using KlinikaProjekt.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Models
{
    public class NewTrainingVM
    {
        public int Id { get; set; }

        [Display(Name = "Training name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Training description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Training poster URL")]
        [Required(ErrorMessage = "Training poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Training start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Training end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Training category is required")]
        public Trainingategory TrainingCategory { get; set; }

        //Relationships
        [Display(Name = "Select doctor(s)")]
        [Required(ErrorMessage = "Training doctor(s) is required")]
        public List<int> DoctorIds { get; set; }

        [Display(Name = "Select a Department")]
        [Required(ErrorMessage = " department is required")]
        public int DepartmentId { get; set; }

        [Display(Name = "Select a patient")]
        [Required(ErrorMessage = "patient is required")]
        public int PatientId { get; set; }
    }
}

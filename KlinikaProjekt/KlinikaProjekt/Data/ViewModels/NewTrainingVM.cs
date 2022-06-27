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

        [Display(Name = "Offer name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Offer description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Offer poster URL")]
        [Required(ErrorMessage = "Offer poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Offer start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Offer end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Offer category is required")]
        public Trainingategory TrainingCategory { get; set; }

        //Relationships
        [Display(Name = "Select doctor(s)")]
        [Required(ErrorMessage = "Offer doctor(s) is required")]
        public List<int> DoctorIds { get; set; }

        [Display(Name = "Select a Department")]
        [Required(ErrorMessage = " department is required")]
        public int DepartmentId { get; set; }

        [Display(Name = "Select a patient")]
        [Required(ErrorMessage = "patient is required")]
        public int PatientId { get; set; }
    }
}

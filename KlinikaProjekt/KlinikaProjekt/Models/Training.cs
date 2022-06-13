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
    public class Training:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Trainingategory TrainingCategory { get; set; }

        //Relationships
        public List<Training_Doctor> Training_Doctor { get; set; }

       
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department{ get; set; }

       
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

    }
}

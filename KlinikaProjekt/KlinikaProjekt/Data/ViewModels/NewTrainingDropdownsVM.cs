
using KlinikaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Data.ViewModels
{
    public class NewTrainingDropdownsVM
    {
        public NewTrainingDropdownsVM()
        {
            Patient = new List<Patient>();
            Department = new List<Department>();
            Doctor = new List<Doctor>();
        }

        public List<Patient> Patient { get; set; }
        public List<Department> Department{ get; set; }
        public List<Doctor> Doctor{ get; set; }
    }
}

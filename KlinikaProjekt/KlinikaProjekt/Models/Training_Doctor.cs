using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Models
{
    public class Training_Doctor
    {
        public int TrainingId { get; set; }
        public Training Training { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}

using KlinikaProjekt.Data.Base;
using KlinikaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Data.Services
{
    public class PatietnsService : EntityBaseRepository<Patient>, IPatientService
    {
        public PatietnsService(AppDbContext context) : base(context)
        {
        }
    }
}

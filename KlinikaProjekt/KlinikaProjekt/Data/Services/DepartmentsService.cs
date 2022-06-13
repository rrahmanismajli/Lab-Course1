using KlinikaProjekt.Data.Base;
using KlinikaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Data.Services
{
    public class DepartmentsService:EntityBaseRepository<Department>, IDepartmentsService
    {
        public DepartmentsService(AppDbContext context) : base(context)
        {
        }
    }
}

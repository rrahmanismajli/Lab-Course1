using KlinikaProjekt.Data.Base;
using KlinikaProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Data.Services
{
    public class DoctorsService : EntityBaseRepository<Doctor>, IDoctorsService
    {
        public DoctorsService(AppDbContext context) : base(context) { }
    }
}

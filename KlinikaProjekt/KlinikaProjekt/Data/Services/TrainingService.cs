using KlinikaProjekt.Data.Base;
using KlinikaProjekt.Data.ViewModels;
using KlinikaProjekt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Data.Services
{
    public class TrainingService : EntityBaseRepository<Training>, ITrainingService
    {
        private readonly AppDbContext _context;
        public TrainingService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewTrainingAsync(NewTrainingVM data)
        {
            var newTraining = new Training()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                DepartmentId = data.DepartmentId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                TrainingCategory = data.TrainingCategory,
                PatientId = data.PatientId
            };
            await _context.Training.AddAsync(newTraining);
            await _context.SaveChangesAsync();

            
            foreach (var doctorId in data.DoctorIds)
            {
                var newTrainingDoctor = new Training_Doctor()
                {
                    
                    DoctorId = doctorId
                };
                await _context.Training_Doctors.AddAsync(newTrainingDoctor);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Training> GetTrainingByIdAsync(int id)
        {
            var TrainingDetails = await _context.Training
                .Include(c => c.Department)
                .Include(p => p.Patient)
                .Include(am => am.Training_Doctor).ThenInclude(a => a.Doctor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return TrainingDetails;
        }

        public async Task<NewTrainingDropdownsVM> GetNewTrainingDropdownsValues()
        {
            var response = new NewTrainingDropdownsVM()
            {
                Doctor = await _context.Doctor.OrderBy(n => n.FullName).ToListAsync(),
                Department = await _context.Department.OrderBy(n => n.Name).ToListAsync(),
                Patient = await _context.Patient.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public async Task UpdateTrainingAsync(NewTrainingVM data)
        {
            var dbTraining = await _context.Training.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbTraining != null)
            {
                dbTraining.Name = data.Name;
                dbTraining.Description = data.Description;
                dbTraining.Price = data.Price;
                dbTraining.ImageURL = data.ImageURL;
                dbTraining.DepartmentId = data.DepartmentId;
                dbTraining.StartDate = data.StartDate;
                dbTraining.EndDate = data.EndDate;
                dbTraining.TrainingCategory = data.TrainingCategory;
                dbTraining.PatientId = data.PatientId;
                await _context.SaveChangesAsync();
            }

            //Remove existing actors
            var existingActorsDb = _context.Training_Doctors.Where(n => n.TrainingId == data.Id).ToList();
            _context.Training_Doctors.RemoveRange(existingActorsDb);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var doctorId in data.DoctorIds)
            {
                var newTrainingDoctor = new Training_Doctor()
                {
                    TrainingId = data.Id,
                   DoctorId = doctorId
                };
                await _context.Training_Doctors.AddAsync(newTrainingDoctor);
            }
            await _context.SaveChangesAsync();
        }
    }
}

using KlinikaProjekt.Data.Base;
using KlinikaProjekt.Data.ViewModels;
using KlinikaProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlinikaProjekt.Data.Services
{
    public interface ITrainingService:IEntityBaseRepository<Training>
    {
        Task<Training> GetTrainingByIdAsync(int id);
        Task<NewTrainingDropdownsVM> GetNewTrainingDropdownsValues();
        Task AddNewTrainingAsync(NewTrainingVM data);
        Task UpdateTrainingAsync(NewTrainingVM data);
    }
}

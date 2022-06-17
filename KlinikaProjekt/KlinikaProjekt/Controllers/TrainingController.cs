using KlinikaProjekt.Data;
using KlinikaProjekt.Data.Services;
using KlinikaProjekt.Data.Static;
using KlinikaProjekt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class TrainingController : Controller
    {
        private readonly ITrainingService _service;

        public TrainingController(ITrainingService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allTraining = await _service.GetAllAsync(n => n.Department);
            return View(allTraining);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allTraining = await _service.GetAllAsync(n => n.Department);

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allMovies.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allTraining.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allTraining);
        }

        //GET: Movies/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetTrainingByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Movies/Create
        public async Task<IActionResult> Create()
        {
            var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();

            ViewBag.Department = new SelectList(trainingDropdownsData.Department, "Id", "Name");
            ViewBag.Patient= new SelectList(trainingDropdownsData.Patient, "Id", "FullName");
            ViewBag.Doctor = new SelectList(trainingDropdownsData.Doctor, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewTrainingVM training)
        {
            if (!ModelState.IsValid)
            {
                var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();
                ViewBag.Department = new SelectList(trainingDropdownsData.Department, "Id", "Name");
                ViewBag.Patient = new SelectList(trainingDropdownsData.Patient, "Id", "FullName");
                ViewBag.Doctor = new SelectList(trainingDropdownsData.Doctor, "Id", "FullName");

                return View(training);
            }

            await _service.AddNewTrainingAsync(training);
            return RedirectToAction(nameof(Index));
        }


        //GET: Movies/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var trainingDetails = await _service.GetTrainingByIdAsync(id);
            if (trainingDetails == null) return View("NotFound");

            var response = new NewTrainingVM()
            {
                Id = trainingDetails.Id,
                Name = trainingDetails.Name,
                Description = trainingDetails.Description,
                Price = trainingDetails.Price,
                StartDate = trainingDetails.StartDate,
                EndDate = trainingDetails.EndDate,
                ImageURL = trainingDetails.ImageURL,
               TrainingCategory = trainingDetails.TrainingCategory,
                //DepartmentId = trainingDetails.DepartmentId,
                PatientId = trainingDetails.PatientId,
                DoctorIds = trainingDetails.Training_Doctor.Select(n => n.DoctorId).ToList(),
            };

            var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();
            ViewBag.Department = new SelectList(trainingDropdownsData.Department, "Id", "Name");
            ViewBag.Patient = new SelectList(trainingDropdownsData.Patient, "Id", "FullName");
            ViewBag.Doctor = new SelectList(trainingDropdownsData.Doctor, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewTrainingVM training )
        {
            if (id !=training.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var trainingDropdownsData = await _service.GetNewTrainingDropdownsValues();
                ViewBag.Department = new SelectList(trainingDropdownsData.Department, "Id", "Name");
                ViewBag.Patient = new SelectList(trainingDropdownsData.Patient, "Id", "FullName");
                ViewBag.Doctor = new SelectList(trainingDropdownsData.Doctor, "Id", "FullName");

                return View(training);
            }

            await _service.UpdateTrainingAsync(training);
            return RedirectToAction(nameof(Index));
        }
    }
}
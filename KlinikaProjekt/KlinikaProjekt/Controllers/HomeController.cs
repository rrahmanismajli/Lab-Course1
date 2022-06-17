using KlinikaProjekt.Data;
using KlinikaProjekt.Data.Services;
using KlinikaProjekt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using KlinikaProjekt.Data.ViewModels;

namespace KlinikaProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDoctorsService _service;
        private readonly AppDbContext _context;
        public HomeController(IDoctorsService service, AppDbContext context)
		{
			_service = service;
			_context = context;
		}


		public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            ViewModel myModel = new ViewModel();

            myModel.Doctors = data;
            myModel.services = await _context.Services.ToListAsync();
            myModel.reviews = await _context.Review.ToListAsync();

            return View(myModel);
            
        }

     
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
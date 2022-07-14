using KlinikaProjekt.Models;
using System.Collections;
using System.Collections.Generic;

namespace KlinikaProjekt.Data.ViewModels
{
	public class ViewModel : ViewModelBase
	{
		public IEnumerable<Doctor> Doctors { get; set; }

		public IEnumerable<KlinikaProjekt.Models.Services> services { get; set; }

		public IEnumerable<Review> reviews { get; set; }
        public IEnumerable<Events> Events { get; set; }
	}
}

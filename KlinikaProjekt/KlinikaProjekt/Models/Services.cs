using System.ComponentModel.DataAnnotations;

namespace KlinikaProjekt.Models
{
	public class Services
	{
		[Key]
		public int id { get; set; }
		[Display(Name ="Icon")]
		public string image { get; set; }
		[Display(Name = "Title")]
		public string title { get; set; }
		[Display(Name = "Description")]
		public string desc { get; set; }

	}
}

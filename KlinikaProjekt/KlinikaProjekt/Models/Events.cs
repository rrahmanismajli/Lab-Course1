using System;
using System.ComponentModel.DataAnnotations;

namespace KlinikaProjekt.Models
{
    public class Events
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string  description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

    }
}

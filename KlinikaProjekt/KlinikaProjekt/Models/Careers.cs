using System;
using System.ComponentModel.DataAnnotations;

namespace KlinikaProjekt.Models
{
    public class Careers
    {
        [Key]
        public int id { get; set; }
        public string image { get; set; }
        public string title { get; set; }

        public string description { get; set; }

        public DateTime deadLine { get; set; }


    }
}

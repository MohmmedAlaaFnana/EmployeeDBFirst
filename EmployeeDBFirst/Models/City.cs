using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDBFirst.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string CityNameArbic { get; set; }
        [Required]
        public string CityNameEnglish { get; set; }

    }
}

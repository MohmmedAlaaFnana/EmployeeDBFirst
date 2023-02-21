using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDBFirst.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="English Name")]
        public string EmployeeNameEnglish { get; set; }
        [Required]
        [Display(Name = "الاسم بالعربية")]
        public string EmployeeNameArabic { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public DateTime HiringDate { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public int? CityId { get; set; }
        [Required]
        public int? DepartmentId { get; set; }

        [Required]
        public virtual City City { get; set; }
        [Required]
        public virtual Department Department { get; set; }
    }
}

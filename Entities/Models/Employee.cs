using System.ComponentModel.DataAnnotations;
using System;
using Entities.Models;

namespace RestaurantAPI.Models
{
    public class Employee
    {
        [Required]
        [Key]
        public int EmpID { get; set; }            // Unique identifier of employee
        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
        public DateTime Start_Date { get; set; }        // Working start date
        public string Job_Title { get; set; }       // Job title of the employee (ex: Cook, Manager)
       
        public int? mgr_ID { get; set; }            // Unique indifier of this employee's mananger
                                                    // Could be null until this one is assigned
    }
}

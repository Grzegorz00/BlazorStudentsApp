using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudentsApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bithday is required")]
        public DateTime Birthday { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Studies are required")]
        public string Studies { get; set; }
    }
}

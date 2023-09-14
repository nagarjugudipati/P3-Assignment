using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Employee
    {
        [Required]
        public int EmpId { get; set; }
        [Required]

        public string EmpName { get; set; }
        [Required]
        public string Destination { get; set; }
    }
}

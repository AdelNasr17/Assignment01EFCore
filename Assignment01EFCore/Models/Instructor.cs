using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Models
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string? Name { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public double HourRate { get; set; }
        public int Dep_Id { get; set; }
    }
}

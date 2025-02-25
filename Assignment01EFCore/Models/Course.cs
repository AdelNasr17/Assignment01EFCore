using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public int Duration { get; set; }
        public string? Description { get; set; }
        public int Top_Id { get; set; }

    }
}

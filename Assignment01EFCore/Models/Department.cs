using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public int Ins_id   { get; set; }
        public DateTime HiringDate { get; set; }
    }
}

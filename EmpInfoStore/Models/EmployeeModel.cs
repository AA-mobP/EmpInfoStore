using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpInfoStore.Models
{
    internal class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

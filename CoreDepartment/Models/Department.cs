using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartment.Models
{
    public class Department
    {
        [Key]
        public int Id{ get; set; }
        public string DepartmentName { get; set; }

        public List<Personal> personals { get; set; }


        
    }
}

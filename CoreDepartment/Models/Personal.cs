using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartment.Models
{
    public class Personal
    {
        [Key]
        public int PerId { get; set; }
        public   string Name{ get; set; }
        public string Surname { get; set; }
        public string City { get; set; }


        public Department dep { get; set; }
    }
}

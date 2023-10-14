using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student:BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}

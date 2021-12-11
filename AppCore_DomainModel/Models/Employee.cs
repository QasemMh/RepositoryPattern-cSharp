using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore_DomainModel.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Name { get; set; }
    }
}

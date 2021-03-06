﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FS20.Models
{
    public class EmployeePosition
    {
        [Key]
        public int EmployeePositionId { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}

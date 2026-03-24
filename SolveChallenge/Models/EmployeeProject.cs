using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SolveChallenge.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(ProjectId))]
    [Table("EmployeeProjects", Schema = "department")]
    internal class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SolveChallenge.Models
{
    [Table("Projects", Schema = "department")]
    internal class Project
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        //[Precision(10, 2)]
        [Column(TypeName = "decimal(10, 2)")]
        public int NOWH { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirst.Models
{
    //[PrimaryKey(nameof(_Id))]
    //[Table(name: "products", Schema = "production")]
    internal class Product
    {
        //[Key]
        //[Column(Order = 0)]
        public int _Id { get; set; }
        //[Column("name")]//, TypeName = "varchar(255)")]
        //[MaxLength(255)]
        //[Unicode(false)]
        public string Name { get; set; } // nvarchar(max)
        public string Img { get; set; } = string.Empty;

        // ?
        // null!
        // string.Empty => ""

        public string? Description { get; set; }

        //[Column(TypeName = "decimal(10, 2)")]
        //[Precision(10, 2)]
        public double Price { get; set; }
        public int Quantity { get; set; }

        //[Column(Order = 1)]
        public DateTime CreateAt { get; set; }

        public int Category_Id { get; set; }
        // Navigation Prop.
        [ForeignKey(nameof(Category_Id))]
        public Category Category { get; set; }

        public List<Order> Orders { get; set; }
    }
}

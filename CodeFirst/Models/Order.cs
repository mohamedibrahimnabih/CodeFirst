using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst.Models
{
    //[PrimaryKey(nameof(UserId), nameof(ProductId))]
    internal class Order
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }

    //class OrderPrimary
    //{
    //    public int UserId { get; set; }
    //    public int ProductId { get; set; }
    //}
}

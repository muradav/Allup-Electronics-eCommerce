using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllupProject.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public double Total { get; set; }

        public double ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}

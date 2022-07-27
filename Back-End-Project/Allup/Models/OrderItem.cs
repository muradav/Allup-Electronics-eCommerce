using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int Count { get; set; }

        public int ProductId { get; set; }

        [NotMappedAttribute]
        public Product Product { get; set; }

        public int OrderId { get; set; }
        [NotMappedAttribute]
        public Order Order { get; set; }


    }
}

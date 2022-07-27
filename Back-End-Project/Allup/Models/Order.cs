using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class Order : Common
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string UserId { get; set; }

        [NotMappedAttribute]
        public User User { get; set; }

        [NotMappedAttribute]
        public List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        InBasket,
        Pending,
        Shipped,

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class Order : Common
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PaymantMethod { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string InvoiceNo { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Delivering,
        Completed,
        Canceled
    }
}

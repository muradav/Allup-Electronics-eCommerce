using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string SendText { get; set; }

        public int ProductId { get; set; }
        public Product Products { get; set; }
    }
}

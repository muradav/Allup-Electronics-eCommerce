using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
    }
}

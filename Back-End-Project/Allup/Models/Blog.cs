using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string ImageUrl { get; set; }

        [NotMappedAttribute]
        public IFormFile Photo { get; set; }
        public List<TagBlog> TagBlogs { get; set; }
    }
}

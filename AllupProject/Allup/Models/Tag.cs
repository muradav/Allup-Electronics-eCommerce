using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class Tag : Common
    {
        public string Name { get; set; }

        [NotMappedAttribute]
        public List<TagProduct> TagProducts { get; set; }
        public List<TagBlog> TagBlogs { get; set; } 
    }
}

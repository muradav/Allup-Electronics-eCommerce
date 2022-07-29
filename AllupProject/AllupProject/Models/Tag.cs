using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllupProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UptadetAt { get; set; }

        [NotMappedAttribute]
        public List<TagProduct> TagProducts { get; set; }
        public List<TagBlog> TagBlogs { get; set; } 
    }
}

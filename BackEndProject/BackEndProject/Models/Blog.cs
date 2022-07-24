using System;

namespace BackEndProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string ImageUrl { get; set; }
    }
}

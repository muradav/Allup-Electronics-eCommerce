using System;

namespace BackEndProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public Nullable<DateTime> UptadetAt { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        

        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}

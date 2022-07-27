using System.ComponentModel.DataAnnotations;

namespace BackEndProject.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}

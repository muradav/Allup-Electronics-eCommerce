using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class Brand : Common
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public List<Product> Products { get; set; }
        public string ImageUrl { get; set; }

        [NotMappedAttribute]
        public IFormFile Image { get; set; }

    }
}

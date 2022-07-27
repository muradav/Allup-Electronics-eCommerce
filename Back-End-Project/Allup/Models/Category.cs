using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class Category : Common
    {
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }

        [NotMappedAttribute]
        public Category Parent { get; set; }

        [NotMappedAttribute]
        public List<Category> Children { get; set; }
        public string ImageUrl { get; set; }

        [NotMappedAttribute]
        public IFormFile Image { get; set; }
        public bool IsDeleted { get; set; }

        [NotMappedAttribute]
        public List<Product> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BackEndProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMappedAttribute]
        public List<TagProduct> TagProducts { get; set; }
    }
}

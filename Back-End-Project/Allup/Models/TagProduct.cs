using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Allup.Models
{
    public class TagProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }

        [NotMappedAttribute]
        public Product Product { get; set; }

        [NotMappedAttribute]
        public Tag Tag { get; set; }

    }
}

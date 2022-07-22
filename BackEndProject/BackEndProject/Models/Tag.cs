﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TagProduct> TagProducts { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}
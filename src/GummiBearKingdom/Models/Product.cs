﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKingdom.Models
{
   [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Country { get; set; }
    }
}

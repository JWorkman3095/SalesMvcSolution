﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvc.Models {
    public class Order {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Desription { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Total { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

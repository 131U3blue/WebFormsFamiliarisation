using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingTipToysMSDN.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Required, StringLength(300), Display(Name = "MerchName")]
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public int CategoryId { get; set; }

        public string ImagePath { get; set; }

        public string ProductDescription { get; set; }

    }
}
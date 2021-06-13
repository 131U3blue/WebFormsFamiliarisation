using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingTipToysMSDN.Models
{
    public class Track
    {
        [ScaffoldColumn(false)]
        public int TrackId { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string TrackName { get; set; }

        [Required, StringLength(100), Display(Name = "Country")]
        public string Country { get; set; }

        [Required, Display(Name = "Date")]
        public DateTime RaceDate { get; set; }

    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WingTipToysMSDN.Models
{
    public class Team
    {
        [ScaffoldColumn(false)]
        public int TeamId { get; set; }

        [Required, StringLength(100), Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required, StringLength(10000), Display(Name = "Description")]
        public string TeamDescription { get; set; }

        [Display(Name = "Team Points")]
        public int? TeamPoints { get; set; }

        public ICollection<Driver> Drivers { get; set; }

    }
}
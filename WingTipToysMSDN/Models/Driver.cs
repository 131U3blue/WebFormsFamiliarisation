using System.ComponentModel.DataAnnotations;

namespace WingTipToysMSDN.Models
{
    public class Driver
    {
        [ScaffoldColumn(false)]
        public int DriverId { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string DriverName { get; set; }
        
        [Required, StringLength(100), Display(Name = "Nationality")]
        public string Nationality { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Driver Points")]
        public int? DriverPoints { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

    }
}
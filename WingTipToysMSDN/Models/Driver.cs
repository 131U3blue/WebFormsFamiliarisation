using System.Collections.Generic;
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
        public int DriverPoints { get; set; }

        public int TeamId { get; set; }

        public int RaceStarts { get; set; }

        public int Wins { get; set; }

        public int Podiums { get; set; }

        public int WorldChampionships { get; set; }

        public int HighestFinish { get; set; }

        public virtual Team Team { get; set; } //Why virtual?

        public ICollection<Result> Results { get; set; }


    }
}
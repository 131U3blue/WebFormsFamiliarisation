using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingTipToysMSDN.Models
{
    public class Result
    {
        [ScaffoldColumn(false)]
        public int ResultId { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Track Track { get; set; }

        [Required, Display(Name = "Finish")]
        public int FinishPosition { get; set; }

        public bool IsWin { get; set; }

        public bool IsPodium { get; set; }

        public int Points { get; set; }

        public Result(int driverId, int trackId, int finishPos)
        {
            var drivers = new SeasonContext().Drivers;
            var tracks = new SeasonContext().Tracks;
            Driver = drivers.FirstOrDefault(d => d.DriverId == driverId);
            Track = tracks.FirstOrDefault(t => t.TrackId == trackId);
            FinishPosition = finishPos;
            IsWin = (finishPos == 1);
            IsPodium = (finishPos <= 3 && finishPos > 0);
            Points = GetPoints(finishPos);
        }

        public static int GetPoints(int finishPos)
        {
            switch (finishPos) {
                case 1: return 25;
                case 2: return 18;
                case 3: return 15;
                case 4: return 12;
                case 5: return 10;
                case 6: return 8;
                case 7: return 6;
                case 8: return 4;
                case 9: return 2;
                case 10: return 1;
                default: return 0;
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysMSDN.Models;

namespace WingTipToysMSDN
{
    public partial class Calendar : System.Web.UI.Page
    {
        public int? TrackId;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addResultsBtn_Click(object sender, CommandEventArgs e)
        {
            var trackIdUrl = e.CommandArgument;
            Response.Redirect("AddResults.aspx?trackId=" + trackIdUrl);
        }

        public IQueryable<Track> GetTracks([QueryString("trackId")] int? trackId)
        {
            TrackId = trackId;
            var _db = new SeasonContext();
            IQueryable<Track> query = _db.Tracks;
            if (trackId.HasValue && trackId > 0) {
                query = query.Where(q => q.TrackId == trackId);
            }
            return query;
        }
    }
}
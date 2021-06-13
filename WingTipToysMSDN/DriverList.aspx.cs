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
    public partial class DriverList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<Driver> GetDrivers([QueryString("id")] int? teamId)
        {
            var _db = new SeasonContext();
            IQueryable<Driver> query = _db.Drivers;
            if (teamId.HasValue && teamId > 0) {
                query = query.Where(q => q.TeamId == teamId);
            }
            return query;
        }
    }
}
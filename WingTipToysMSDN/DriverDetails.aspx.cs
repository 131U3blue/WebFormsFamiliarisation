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
    public partial class DriverDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Driver> GetDriver([QueryString("driverId")] int? driverId)
        {
            var _db = new SeasonContext();
            IQueryable<Driver> query = _db.Drivers;
            if (driverId.HasValue && driverId > 0) {
                query = query.Where(q => q.DriverId == driverId);
            }
            else {
                query = null;
            }
            return query;
        }

        public static int GetDriverPosition(int driverId)
        {
            var _db = new Models.SeasonContext();
            IQueryable<Driver> query = _db.Drivers;
            List<Driver> orderedQuery = query.OrderByDescending(q => q.DriverPoints).ToList();
            int position = 0;
            for (int i = 0; i < orderedQuery.Count(); i++) {
                if (orderedQuery[i].DriverId == driverId) {
                    position = i + 1;
                }
            }
            return position;
        }
    }
}
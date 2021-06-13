using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysMSDN.Models;

namespace WingTipToysMSDN
{
    public partial class AddResults : System.Web.UI.Page
    {
        public static int TrackId;
        public static SeasonContext _driverDb = new SeasonContext();


        protected override void Render(HtmlTextWriter writer)
        {
            foreach (Control c in Controls) {
                this.Page.ClientScript.RegisterForEventValidation(c.UniqueID.ToString());
            }
            base.Render(writer);
        }

        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack) {
                var ddList = GetDropDown();                
                ddList.DataSource = CreateDataSource();
                ddList.DataTextField = "DriverName";
                ddList.DataValueField = "DriverId";
                ddList.DataBind();
                var driverList = new List<Driver>();
                foreach (var driver in _driverDb.Drivers) {
                    driverList.Add(driver);
                }

                DriverRepeater.DataSource = driverList;
                DriverRepeater.DataBind();
            }
        }

        public DropDownList GetDropDown()
        {
            DropDownList dropDownList = new DropDownList();
            foreach (RepeaterItem item in DriverRepeater.Items) {                
                if (item.FindControl("ddList") != null) {
                    dropDownList = (DropDownList)item.FindControl("ddList");
                }
                else { Console.WriteLine("NULL"); }
            }
            return dropDownList;
        }

        ICollection CreateDataSource()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("DriverName", typeof(string)));
            dt.Columns.Add(new DataColumn("DriverId", typeof(int)));

            foreach(var driver in _driverDb.Drivers) {
                dt.Rows.Add(CreateRow(driver.DriverName, driver.DriverId, dt));
            }

            DataView dv = new DataView(dt);
            return dv;
        }

        DataRow CreateRow(string text, int value, DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr[0] = text;
            dr[1] = value;
            return dr;
        }

        public static List<string> GetDriverNames(List<Driver> driverList)
        {            
            var driverNames = new List<string>();
            foreach (var driver in driverList) {
                driverNames.Add(driver.DriverName);

            }            
            return driverNames;
        }


    }
}
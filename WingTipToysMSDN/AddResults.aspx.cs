using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTipToysMSDN.Models;

namespace WingTipToysMSDN
{
    public partial class AddResults : System.Web.UI.Page
    {
        private static int TrackId;
        private static SeasonContext _driverDb = new SeasonContext();
        private static List<Driver> Drivers = _driverDb.Drivers.ToList(); 


        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack) {
                var driverList = new List<Driver>();
                foreach (var driver in _driverDb.Drivers) {
                    driverList.Add(driver);
                }                
                DriverRepeater.DataSource = driverList;
                DriverRepeater.DataBind();
            }
        }

        public static List<string> GetDriverNames([QueryString("trackId")] int trackId, List<Driver> driverList)
        {
            TrackId = trackId;
            var driverNames = new List<string>();
            foreach (var driver in driverList) {
                driverNames.Add(driver.DriverName);
            }
            return driverNames;
        }

        protected void SubmitBtn_CheckAndSubmitResults(object sender, EventArgs e)
        {
            TrackId = Convert.ToInt32(Request.QueryString["trackId"]);
            Button submitBtn = (Button)sender;
            var listOfDropDownLists = new List<DropDownList>();
            foreach (RepeaterItem item in DriverRepeater.Items) {
                DropDownList ddList = (DropDownList)item.FindControl("ddList");
                listOfDropDownLists.Add(ddList);
            }
            if (CheckForDuplicateSelections(listOfDropDownLists)) {
                var results = CalculateResult(listOfDropDownLists);
                Track thisTrack = _driverDb.Tracks.FirstOrDefault(t => t.TrackId == TrackId);
                thisTrack.Results = results;
            }
            else {
                var message = "Cannot submit the same driver with different finishing results.";
                Response.Write("<script language='javascript'>alert('" + message + "')</script>");
            }
        }

        protected bool CheckForDuplicateSelections(List<DropDownList> listOfDropDownLists)
        {
            var selectionList = new List<int>();
            foreach(var dropDownList in listOfDropDownLists) {
                selectionList.Add(Convert.ToInt32(dropDownList.SelectedItem.Value));
            }
            IEnumerable<int> duplicates = selectionList.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
            if (duplicates.Count() > 0) {
                return false;
            }
            else return true;
        }

        protected List<Result> CalculateResult(List<DropDownList> listOfDropDownLists)
        {
            var results = new List<Result>();
            for (int i = 0; i < listOfDropDownLists.Count; i++) {
                var dropDown = listOfDropDownLists[i];
                var result = new Result(Convert.ToInt32(dropDown.SelectedValue), TrackId, i + 1);
                foreach (var driver in _driverDb.Drivers) {
                    if (result.DriverId == driver.DriverId) {
                        driver.UpdateDetails(result);
                        driver.Results.Add(result);
                    }
                }
                results.Add(result);
            }
            _driverDb.SaveChanges();
            return results;
        }

        private void UpdateDriverDb(Result raceResult)
        {

        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (Control c in Controls) {
                Page.ClientScript.RegisterForEventValidation(c.UniqueID.ToString());
            }
            base.Render(writer);
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

        protected void DriverRepeater_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType != ListItemType.Item && e.Item.ItemType != ListItemType.AlternatingItem) {
                return;
            }
            var ddList = e.Item.FindControl("ddList") as DropDownList;
            ddList.DataSource = CreateDataSource();
            ddList.DataTextField = "DriverName";
            ddList.DataValueField = "DriverId";
            ddList.DataBind();
        }

        ICollection CreateDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("DriverName", typeof(string)));
            dt.Columns.Add(new DataColumn("DriverId", typeof(int)));

            foreach (var driver in _driverDb.Drivers) {
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
    }
}
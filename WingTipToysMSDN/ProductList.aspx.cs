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
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId)
        {
            var _db = new SeasonContext();
            IQueryable<Product> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0) {
                query = query.Where(q => q.CategoryId == categoryId);
            }
            return query;
        }
    }
}
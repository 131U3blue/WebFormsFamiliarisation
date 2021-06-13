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
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProduct([QueryString("productId")] int? productId)
        {
            var _db = new SeasonContext();
            IQueryable<Product> query = _db.Products;
            if (productId.HasValue && productId > 0) {
                query = query.Where(q => q.ProductId == productId);
            }
            else {
                query = null;
            }
            return query;
        }
    }
}
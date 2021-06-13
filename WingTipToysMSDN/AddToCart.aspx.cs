using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using WingTipToysMSDN.Logic;

namespace WingTipToysMSDN
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductID"];
            int productId;
            if(!string.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId)) {
                using (CartActions userCart = new CartActions()) {
                    userCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else {
                Debug.Fail("SHOULD NOT ACCESS AddToCart.aspx WITHOUT A ProductId.");
                throw new Exception("CANNOT LOAD AddToCart.aspx WITHOUT SETTING ProductId.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}
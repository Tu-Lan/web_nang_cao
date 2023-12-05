using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SneakerShop
{
    public partial class Xoagiohang : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString.Get("id");

            var cookie = Request.Cookies["cart"].Value;
            var currentCart = JsonConvert.DeserializeObject<List<cart>>(cookie);

            var product = currentCart.Where(x => x.Id == id).FirstOrDefault();

            currentCart.Remove(product);
            
            Response.Cookies["cart"].Value = JsonConvert.SerializeObject(currentCart);

            Response.Redirect("Giohang.aspx");
        }
    }
}
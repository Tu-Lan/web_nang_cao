using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SneakerShop
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>HELLO " + Session["username"].ToString().ToUpper() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> SIGN OUT </a>";

            }
            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> phone_lap = new List<Product>();
            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "1" || id == "2" || id == "5" || id == "6" || id == "7" || id == "8" || id == "9" || id == "10")
                {
                    phone_lap.Add(product);
                }
            }
            phone_lap1.DataSource = phone_lap;
            phone_lap1.DataBind();

        }
    }
}
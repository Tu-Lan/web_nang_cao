using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SneakerShop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblOnlineUsers.Text = $"Số người đang online: {Application["onlineUsers"]}";
            if (Session["username"] != null)
            {
                // Lấy địa chỉ IP của người dùng
                string ipAddress =null;
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                         ipAddress = ip.ToString();
                    }
                }

                // Hiển thị địa chỉ IP trong một thẻ HTML
                ip_address.InnerHtml = $"<p>Địa chỉ IP của bạn: {ipAddress}</p>";

                login.InnerHtml = "<p class='user'>HELLO " + Session["username"].ToString().ToUpper() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> SIGN OUT </a>";
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }

            List<Product> ProductList = (List<Product>)Application["productList"];
            List<Product> banchay = new List<Product>();
            List<Product> phobien = new List<Product>();

            foreach (Product product in ProductList)
            {
                string id = product.Id;
                if (id == "1" || id == "2" || id == "3" || id == "4" )
                {
                    banchay.Add(product);
                }
                /*
                if (id == "10" || id == "11" || id == "12" || id == "13" || id == "14" )
                {
                    phobien.Add(product);
                }    */
            }
            sanphambanchay.DataSource = banchay;
            sanphambanchay.DataBind();
           /* sanphamphobien.DataSource = phobien;
            sanphamphobien.DataBind();*/
        }
        private string GetClientIpAddress()
        {
            string ipAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ipAddress))
            {
                ipAddress = HttpContext.Current.Request.UserHostAddress;
            }

            return ipAddress;
        }


    }
}
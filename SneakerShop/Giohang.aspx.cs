using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SneakerShop
{
    public partial class Giohang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                int soluot = Convert.ToInt32(Application["sogiohang"]);
                login.InnerHtml = "<p class='user'>HELLO " + Session["username"].ToString().ToUpper() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> SIGN OUT </a>";

                if (Request.Cookies["cart"] != null)
                {
                    var cookie = Request.Cookies["cart"].Value;
                    var cartList = JsonConvert.DeserializeObject<List<cart>>(cookie);
                    //List<Product> cartList = new List<Product>();

                    //List<Product> productList = (List<Product>)Application["ProductList"];
                    //string[] productsID = Request.Cookies["cart"].Value.Split(',');
                    //foreach (string productID in productsID)
                    //{
                    //    foreach (Product product in productList)
                    //    {
                    //        if (product.Id == productID)
                    //        {   
                    //            soluot ++;
                    //            cartList.Add(product);

                    //        }
                    //    }
                    //    sogiohang.InnerHtml = "<p> Number of products in the shopping cart is: " + soluot +"</p>";
                    //}

                    foreach(var item in cartList)
					{
                        soluot += item.Quantity;
					}

                    sogiohang.InnerHtml = "<p> Number of products in the shopping cart is: " + soluot + "</p>";
                    ListViewCart.DataSource = cartList;
                    ListViewCart.DataBind();

                    //Display products price toan bo san pham

                    var productsPrice = 0;

                    foreach(var item in cartList)
					{
                        productsPrice += item.Quantity * Int32.Parse(item.Price);
					}

                    //foreach (Product product in cartList) productsPrice += Int32.Parse(product.Price);
                    products_price.InnerHtml = $"{productsPrice} <span class='cart__product-price-unit'>$</span>";

                    //Display delivery price phi ship
                    const int DELIVERY = 5;
                    delivery_price.InnerHtml = $"{DELIVERY} <span class='cart__product-price-unit'>$</span>";
                    //Display order total price
                    int orderTotal = productsPrice + DELIVERY;
                    order_total_price.InnerHtml = $"{orderTotal} <span class='cart__product-price-unit'>$</span>";
                }
                else
                {
                    Response.Redirect("Trangchu.aspx");
                }
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }
        }
    }
}
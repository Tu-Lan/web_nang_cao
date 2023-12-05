using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SneakerShop
{
    public partial class Trangsanphamchitiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                login.InnerHtml = "<p class='user'>HELLO " + Session["username"].ToString().ToUpper() + " | " + "</p>" +
                                  "<a href = 'Dangxuat.aspx'> SIGN OUT </a>";


            }
            string id = Request.QueryString.Get("id");

            if (id != null)
            {
                List<Product> ProductList = (List<Product>)Application["productlist"];
                List<Product> Productinformation = new List<Product>();
                foreach (Product product in ProductList)
                {
                    if (id == product.Id)
                    {
                        Productinformation.Add(product);

                    }
                    ListViewProductinformation.DataSource = Productinformation;
                    ListViewProductinformation.DataBind();
                }
            }
            else
            {
                Response.Redirect("Trangchu.aspx");
            }
        }
        protected void AddToCartButton(object sender, EventArgs e)
        {
            System.Web.UI.Page page = (System.Web.UI.Page)HttpContext.Current.Handler;

            if (Session["username"] != null)
            {
                List<Product> ProductList = (List<Product>)Application["productlist"];
                string id = Request.QueryString.Get("id");
                var cartList = new List<cart>();

                //Store cart to cookies
                if (Request.Cookies["cart"] == null)
                {
                    //Response.Cookies["cart"].Value = $"{id},";
                    //Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);

                    var product = ProductList.Where(x => x.Id == id).FirstOrDefault();

                    if(product == null)
					{
                        page.ClientScript.RegisterStartupScript(this.GetType(), "a", "alert('Product do not exits');", false);
                    }

                    var item = new cart()
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Images = product.Images,
                        Quantity = 1,
                    };

                    cartList.Add(item);

					Response.Cookies["cart"].Value = JsonConvert.SerializeObject(cartList);
					Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
				} else {

                    //	Store cookies by productID, example: 1,2,3,40,50,... 
                    //                Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + $"{id},";
                    //	Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);

                    var cartCookie = Request.Cookies["cart"].Value;
                    cartList = JsonConvert.DeserializeObject<List<cart>>(cartCookie);

                    var cart = cartList.Where(x => x.Id == id).FirstOrDefault();

                    if (cart != null)
                    {
                        cart.Quantity++;
                    } else
					{
                        var product = ProductList.Where(x => x.Id == id).FirstOrDefault();

                        var newItem = new cart()
                        {
                            Id = product.Id,
                            Name = product.Name,
                            Price = product.Price,
                            Images = product.Images,
                            Quantity = 1,
                        };

                        cartList.Add(newItem);
					}

                    Response.Cookies["cart"].Value = JsonConvert.SerializeObject(cartList);
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }

                //Refresh to update cart number
                //Response.Redirect(Request.Url.ToString());
                // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "msg", "alert('Added to your cart')", true);

                page.ClientScript.RegisterStartupScript(this.GetType(), "a", "alert('Added to your cart');", true);



                //Themgio.InnerHtml = "Thêm thành công";
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }
        }



        /*protected void AddToCartButton(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                string id = Request.QueryString.Get("id");

                // Kiểm tra nếu sản phẩm đã có trong Giỏ hàng
                if (GioHangDaTonTai(id))
                {
                    // Nếu có, tăng số lượng lên
                    TangSoLuongSanPhamTrongGioHang(id);
                }
                else
                {
                    // Nếu chưa, thêm sản phẩm mới vào Giỏ hàng
                    ThemSanPhamMoiVaoGioHang(id);
                }

                // Hiển thị thông báo
                System.Web.UI.Page page = (System.Web.UI.Page)HttpContext.Current.Handler;
                page.ClientScript.RegisterStartupScript(this.GetType(), "a", "alert('Đã thêm vào giỏ hàng');", true);
            }
            else
            {
                Response.Redirect("Dangnhap.aspx");
            }
        }

        private bool GioHangDaTonTai(string id)
        {
            // Đây là nơi bạn kiểm tra xem sản phẩm có trong Giỏ hàng không
            // Điều này phụ thuộc vào cách bạn lưu trữ dữ liệu Giỏ hàng, có thể là Cookies, Session, Database, ...
            // Ở đây, giả sử sử dụng Cookies, và lấy giá trị từ Cookies "cart"

            HttpCookie cartCookie = Request.Cookies["cart"];

            if (cartCookie != null)
            {
                // Tách chuỗi thành mảng để kiểm tra
                string[] productIds = cartCookie.Value.Split(',');

                // Kiểm tra nếu sản phẩm đã có trong Giỏ hàng
                return Array.Exists(productIds, productId => id == productId);
            }

            return false;
        }

        private void TangSoLuongSanPhamTrongGioHang(string id)
        {
            // Đây là nơi bạn thực hiện logic tăng số lượng sản phẩm trong Giỏ hàng

            HttpCookie cartCookie = Request.Cookies["cart"];

            if (cartCookie != null)
            {
                // Tách chuỗi thành mảng để kiểm tra
                string[] productIds = cartCookie.Value.Split(',');

                // Kiểm tra nếu sản phẩm đã có trong Giỏ hàng
                if (Array.Exists(productIds, productId => id == productId))
                {
                    // Tăng số lượng sản phẩm
                    for (int i = 0; i < productIds.Length; i++)
                    {
                        if (productIds[i] == id)
                        {
                            // Tăng số lượng sản phẩm ở đây
                            // Đối với Cookies, bạn có thể lưu số lượng sản phẩm ngay sau id, ví dụ: "1-2,2,3,40,50,..."
                            string[] productInfo = productIds[i].Split('-');
                            int currentQuantity = int.Parse(productInfo.Length > 1 ? productInfo[1] : "1");
                            currentQuantity++;

                            // Cập nhật số lượng và gán lại giá trị cho Cookies
                            productIds[i] = $"{id}-{currentQuantity}";
                        }
                    }

                    // Gán lại giá trị cho Cookies
                    Response.Cookies["cart"].Value = string.Join(",", productIds);
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
                else
                {
                    // Nếu sản phẩm chưa có trong giỏ hàng, bạn thêm sản phẩm mới vào đây
                    // Đối với Cookies, bạn thêm sản phẩm vào giá trị của Cookies

                    Response.Cookies["cart"].Value = $"{id},";
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
                }
            }
        }





        private void ThemSanPhamMoiVaoGioHang(string id)
        {
            // Nếu sản phẩm chưa có trong Giỏ hàng, bạn thêm sản phẩm mới vào đây
            // Đối với Cookies, bạn thêm sản phẩm vào giá trị của Cookies

            if (Request.Cookies["cart"] == null)
            {
                Response.Cookies["cart"].Value = $"{id},";
                Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
            }
            else
            {
                // Store cookies by Id, example: 1,2,3,40,50,...
                Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + $"{id},";
                Response.Cookies["cart"].Expires = DateTime.Now.AddDays(14);
            }
        }
*/

    }
}
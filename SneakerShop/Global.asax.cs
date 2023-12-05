using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SneakerShop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //tạo biến số người online
            //Application["onlineUsers"] = 0;


            //tk mac dinh
            Application["Users"] = new List<NguoiDung>();
            List<NguoiDung> Users = (List<NguoiDung>)Application["Users"];
            Users.Add(new NguoiDung("dacquyet", "luuphuongvy0209@gmail.com", "123456", "123456"));
            Users.Add(new NguoiDung("quyduy", "quyduy@gmail.com", "123456", "123456"));
            Users.Add(new NguoiDung("quydu", "duydu2002@gmail.com", "123456", "123456"));

            //sanpham
            Application["ProductList"] = new List<Product>();
            List<Product> ProductList = new List<Product>();
            //san pham ban chay
            ProductList.Add(new Product() { Id = "1", Images = "../images/iphone15.jpg", Name = "Iphone 15 Pro Max", Price = "1199", 
                Detail = "Thiết kế bằng titan. Mặt trước Ceramic Shield. Thiết kế mặt sau bằng kính nhám. Màn hình toàn phần OLED 6,7 inch. Chip A17 Pro"});
            ProductList.Add(new Product() { Id = "2", Images = "../images/iphone15plus.jpg", Name = "Iphone 15 Plus'", Price = "899",
                Detail= "6.7-inch durable color-infused glass. Dynamic Island bubbles up alerts. A16 Bionic powers computational. 48MP Main camera with 2x Telephoto. Connect and charge with USB-C." });
            ProductList.Add(new Product() { Id = "3", Images = "../images/sss23ultra.jpg", Name = "SamSung Galaxy S23 Ultra", Price = "1309", 
                Detail= "SAMSUNG Galaxy S23 Ultra Cell Phone, Unlocked Android Smartphone, 512GB, 200MP Camera, S Pen, Night Mode, Record 8K Video, Long Battery Life, Fastest Mobile Processor, US Version, 2023, Green"
            });
            ProductList.Add(new Product() { Id = "4", Images = "../images/sszfold5.jpg", Name = "SamSung Galaxy Z Fold 5", Price = "1619", 
                Detail= "SAMSUNG Galaxy Z Fold 5 Cell Phone, Factory Unlocked Android Smartphone, 512GB, Big 7.6” Screen for Streaming, Gaming, Dual App View, One-Hand Control, Hands-Free Use, US Version, 2023, Icy Blue"
            });
           
            
            //sanpham liên quan đến điện thoại máy tính
            ProductList.Add(new Product() { Id = "5", Images = "../images/Phones_computer/iphone14.png", Name = "Iphone 14", Price = "699", 
                Detail = "iPhone 14, 256GB, Graphite - Unlocked (Renewed Premium)"
            });
            ProductList.Add(new Product() { Id = "6", Images = "../images/Phones_computer/iphone13.png", Name = "Iphone 13'", Price = "599",
                Detail = "iPhone 13, 256GB, Graphite - Unlocked (Renewed Premium)"
            });
            ProductList.Add(new Product() { Id = "7", Images = "../images/Phones_computer/ssglxBook3.png", Name = "SAMSUNG 15.6” Galaxy Book3", Price = "899",
                Detail = "SAMSUNG 15.6” Galaxy Book3 Laptop PC Computer, 13th Gen Intel Core i7-1360P Processor/16 GB/512GB, Thin, Light, FHD Screen, Fingerprint Reader, HD Webcam, ARC A350M, 2023 Model, NP750XFH-XB1US, Silver"
            });
            ProductList.Add(new Product() { Id = "8", Images = "../images/Phones_computer/lggam.png", Name = "LG gram", Price = "899", 
                Detail = "LG gram 14” 2in1 Lightweight Laptop, Intel 13th Gen Core i5 Evo Platform, Windows 11 Home, 16GB RAM, 512GB SSD, Black"
            });
            ProductList.Add(new Product() { Id = "9", Images = "../images/Phones_computer/asusrog.png", Name = "ASUS ROG Strix G17", Price = "2199", 
                Detail = "ASUS ROG Strix G17 (2023) Gaming Laptop, 17.3” QHD 240Hz, GeForce RTX 4070, AMD Ryzen 9 7945HX, 16GB DDR5, 1TB PCIe SSD, Wi-Fi 6E, Windows 11, G713PI-DS94 Eclipse Gray"
            });
            ProductList.Add(new Product() { Id = "10", Images = "../images/Phones_computer/macairm2.png", Name = "MacBook Air Laptop with M2 chip", Price = "1298", 
                Detail = "Apple 2023 MacBook Air Laptop with M2 chip: 15.3-inch Liquid Retina Display, 8GB Unified Memory, 256GB SSD Storage; Midnight with AppleCare+"
            });


            //sanpham dong ho 
            ProductList.Add(new Product() { Id = "11", Images = "../images/phukien/Gimbal.png",
                Name = "FeiyuTech Action Camera Gimbal",
                Price = "8188",
                Detail = "Built-in extension rod. Battery life: 10 hours. Compatible with gopro hero,8/7/6/5, yi 4k,sj 6 legend.Light - weight. Motor locking mechanism provides protection during transportation"
            });
            ProductList.Add(new Product() { Id = "12", Images = "../images/phukien/headphone.png", Name = "Audio-Technica", Price = "1250", Detail = "Audio-Technica ATH-AP2000TI Closed-Back Headphones, Black" });
            ProductList.Add(new Product() { Id = "13", Images = "../images/phukien/Sceptre24inch.png", Name = "Sceptre 24-inch Professional", Price = "99", Detail = "Sceptre 24-inch Professional Thin 1080p LED Monitor 99% sRGB 2x HDMI VGA Build-in Speakers, Machine Black (E248W-19203R Series)" });
            ProductList.Add(new Product() { Id = "14", Images = "../images/phukien/mouse.png", Name = "CORSAIR Gaming Mouse", Price = "129", Detail = "CORSAIR SCIMITAR ELITE RGB WIRELESS MMO Gaming Mouse - 26,000 DPI - 16 Programmable Buttons - Up to 150hrs Battery - iCUE Compatible - Black" });
            ProductList.Add(new Product() { Id = "15", Images = "../images/phukien/ram.png", Name = "Lexar ARES RGB 32GB (2x16GB) DDR5", Price = "119", Detail = "Lexar ARES RGB 32GB (2x16GB) DDR5 RAM 6000MT/s CL30 Desktop Memory - AMD Expo and Intel XMP 3.0 (Black) LD5BU016G-R6000GDLA" });
            ProductList.Add(new Product() { Id = "16", Images = "../images/phukien/iteli9.png", Name = "Intel Core i9 (12th Gen)", Price = "348", Detail = "Intel Core i9 (12th Gen) i9-12900KS Gaming Desktop Processor with Integrated Graphics and Hexadeca-core (16 Core) 2.50 GHz" });
            


            Application["ProductList"] = ProductList;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["product"] = new List<Product>();
            Session["login"] = 0;
            /*Application.Lock(); // Đảm bảo không có ai khác có thể truy cập đồng thời
            Application["onlineUsers"] = (int)Application["onlineUsers"] + 1; // Tăng số người đang online
            Application.UnLock(); // Mở khóa*/
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            /*Application.Lock();
            Application["onlineUsers"] = (int)Application["onlineUsers"] - 1; // Giảm số người đang online khi một phiên kết thúc
            Application.UnLock();*/
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gioithieu.aspx.cs" Inherits="SneakerShop.gioithieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Giới thiệu</title>
    <link href="Style/gioithieu.css" rel="stylesheet" />
</head>
<body>
     <div class="header">
		<div class="header_top" id="header-top">
			<img  src="images/Global.png" title="global">
			<p>English/USA</p>
			<div id="login" class="login" runat="server">
				<p class="user"></p>
				<a class="TrangDangNhap" href="Dangnhap.aspx" title="Đăng nhập">SIGN IN</a>
				<a href="Dangky.aspx" title="Đăng ký">SIGN UP</a>
			</div>	
		</div>
		 
		<div class="header_bot" id="header-bot">
			<a href="Trangchu.aspx">
				<img class="imgLogo" width="200" height="80" src="images/logo.png" title="Logo">
			</a>
			<ul>
				<li><a href="Trangchu.aspx">HOME</a></li>
				
				<li><a href="phone_lap.aspx">PHONE & LAP</a></li>
				<li><a href="accessory.aspx">ACCESSORY</a></li>
				<li><a href="Lienhe.aspx">CONTACT</a></li>
				<li><a id="selected" href="gioithieu.aspx">ABOUT US</a></li>
				<li>
					<div class="gioHang"> 
						<a href="Giohang.aspx">CART</a>

					</div>
			</li>			 
			</ul>
		</div>
	</div>

    <div class="gioithieu">
        <div class="gioithieu_column_one">
            <img src="images/gioithieu.png" alt="lỗi" width="100%">
        </div>
        <div class="gioithieu_column_two">
            <h2>About KickSwap</h2>
            <span>
                “Welcome to KickSwap, your premier destination for cutting-edge electronics! Step into a world where innovation meets convenience, and explore a curated selection of the latest and greatest in electronic devices. At KickSwap, we pride ourselves on being your one-stop shop for all things tech, offering a diverse range of high-quality smartphones, laptops, and other gadgets that cater to your digital lifestyle.
Our commitment to providing the latest technology ensures that you stay ahead of the curve, always having access to the most advanced and reliable electronic devices on the market.
We understand that technology plays a pivotal role in our daily lives, and we are passionate about bringing you the tools that enhance your connectivity, productivity, and entertainment. Please explore our website and discover a world of possibilities as you embrace the future with the latest and greatest electronics. Welcome to a digital revolution – welcome to KickSwap!”
            </span>
        </div>
    </div>
    <div class="section_content">
        <div class="section_item">
            <div class="section_child">
                <h3>Authentic</h3>
                <span>Nowadays, technology devices are an indispensable part of today's modern people.</span>
            </div>
            <div class="section_child">
                <h3>New product</h3>
                <span>Nowadays, technology devices are an indispensable part of today's modern people.</span>
            </div>
            <div class="section_child">
                <h3>12 months warranty</h3>
                <span>Nowadays, technology devices are an indispensable part of today's modern people.</span>
            </div>
        </div>
        <div class="section_item">
            <div class="section_child">
                <h3>Free return within 7 daysy</h3>
                <span>Nowadays, technology devices are an indispensable part of today's modern people.</span>
            </div>
            <div class="section_child">
                <h3>Free Shipping</h3>
                <span>
                    Nowadays, technology devices are an indispensable part of today's modern people.
                </span>
            </div>
            <div class="section_child">
                <h3>Best price</h3>
                <span>Nowadays, technology devices are an indispensable part of today's modern people.</span>
            </div>
        </div>
    </div>
    <div class="section_img">
        <img src="images/test1.jpg" alt="photo" width="100%">
    </div>

    

     <div class="footer">
		<div class="footer_top">
			 
			<div class="footer-section">
				<h1>SHOP</h1>
				<ul>
					<li><a href="phone_lap.aspx">PHONE & LAP</a></li>
					<li><a href="accessory.aspx">ACCESSORY</a></li>
					<li><a href="Lienhe.aspx">CONTACT</a></li>
					<li><a href="gioithieu.aspx">ABOUT US</a></li>
				</ul>
			</div>
			<div class="footer-section">
				<h1>FOR YOU</h1>
				<ul>
					<li><a href="#">FREQUENTLY ASKED QUESTION</a></li>
					<li><a href="#">SHIPPING</a></li>
					<li><a href="#">RETURNS AND EXCHANGES</a></li>
					<li><a href="#">SIZES GUIDES</a></li>
					<li><a href="#">GIFT CARDS</a></li>
				</ul>
			</div>
		</div>
		<div class="footer_bot">
			 
        		©Đắc Quyết - 20A01
			 
		</div>
	</div>

</body>
</html>

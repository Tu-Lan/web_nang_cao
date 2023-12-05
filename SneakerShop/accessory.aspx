<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accessory.aspx.cs" Inherits="SneakerShop.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đồng hồ nữ</title>
    <link href="Style/giaynu.css" rel="stylesheet" />
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
				
				<li><a  href="phone_lap.aspx">PHONE & LAP</a></li>
				<li><a id="selected" href="accessory.aspx">ACCESSORY</a></li>
				<li><a href="Lienhe.aspx">CONTACT</a></li>
				<li><a href="gioithieu.aspx">ABOUT US</a></li>
				<li>
					<div class="gioHang"> 
						<a href="Giohang.aspx">CART</a>

					</div>



				</li>
				 
				 
			</ul>
		</div>
	</div>
    <div class="up">
        <div class="abc">
            <a href="Trangchu.aspx"><strong>HOME</strong></a> / <a href="accessory.aspx"><strong>WOMEN'S SHOES</strong></a>
        </div>
    </div>
	<div class="container">
		
      <div class="sidebar_one">
            <div class="row_1">
                <strong>CATALOGUE</strong>
                <div class="show">
                    <ul>
                        <li><a href="phone_lap.aspx">PHONE & LAP</a></li>
                        <li><a href="accessory.aspx">ACCESSORY</a></li>
                    </ul>
                </div>
            </div>
             
        </div>
        <div class="sidebar_two">
            <div class="sanpham">
                <asp:ListView ID="accessory1" runat="server">
                    <ItemTemplate>
                        <a href="Trangsanphamchitiet.aspx?id=<%# Eval("Id") %>">
                            <div class="sanpham_show">
                                <img src="<%# Eval("Images") %>" alt="ảnh lỗi">
                                <div class="sanpham_gia">
                                    <strong><%# Eval("Name") %></strong>
                                    <p><%# Eval("Price") %>$</p>
                                </div>
                            </div>
                        </a>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </div>
    <div class="footer">
		<div class="footer_top">
			 
			<div class="footer-section">
				<h1>SHOP</h1>
				<ul>
					<li><a href="phone_lap.aspx">MEN'S</a></li>
					<li><a href="accessory.aspx">WOMEN'S</a></li>
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

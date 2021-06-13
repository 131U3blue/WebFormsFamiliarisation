<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WingTipToysMSDN.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="WingTipToysMSDN.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <div>
                <a href="ProductList.aspx">
                    <span style="color:white; font-size:larger">Back To Merch</span>
                </a>
            </div>
            <table style="font-size:larger">
                <tr>
                    <td>
                        <img src="<%#:Item.ImagePath %>" style="border:solid; border-color:red" alt="<%#:Item.ProductName %>" width="860" height="860"/>
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <span style="font-size:large">Price:&nbsp;£<%#:Item.ProductPrice %>.00</span>
                        <br />
                        <br />
                        <span  style="font-weight:200">&nbsp;<%#:Item.ProductDescription %></span>
                        <br />
                        <br />
                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductId %>">               
                            <span style="font-size:x-large" class="ProductListItem">
                                <b>Add To Cart<b>
                            </span>           
                        </a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
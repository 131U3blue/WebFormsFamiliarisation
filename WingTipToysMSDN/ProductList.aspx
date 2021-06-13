<%@ Page Title="Merch" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WingTipToysMSDN.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="productList" runat="server"
                DataKeyNames="ProductId" GroupItemCount="2"
                ItemType="WingTipToysMSDN.Models.Product" SelectMethod="GetProducts" >
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No merch found</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productId=<%#:Item.ProductId %>">
                                        <img src="<%#: Item.ImagePath %>"
                                            width="480" height="480" style="border: solid; border-color:red" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProductDetails.aspx?productId=<%#:Item.ProductId %>">
                                        <span>
                                            <%#:Item.ProductName %>
                                        </span>
                                    </a>
                                    <br />
                                    <a href="ProductDetails.aspx?productId=<%#:Item.ProductId %>">
                                        <span>
                                            <b>Price: £</b><%#:Item.ProductPrice %>.00
                                        </span>
                                    </a>
                                    <br />
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductId %>">               
                                        <span style="font-size:x-large" class="ProductListItem">
                                            <b>Add To Cart<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainers" runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>

</asp:Content>

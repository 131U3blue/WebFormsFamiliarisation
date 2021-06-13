<%@ Page Title="Drivers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DriverList.aspx.cs" Inherits="WingTipToysMSDN.DriverList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="driverList" runat="server"
                DataKeyNames="DriverId" GroupItemCount="2"
                ItemType="WingTipToysMSDN.Models.Driver" SelectMethod="GetDrivers" >
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No drivers found for this team</td>
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
                                    <a href="DriverDetails.aspx?driverId=<%#:Item.DriverId %>">
                                        <img src="<%#: Item.ImagePath %>"
                                            width="480" height="480" style="border: solid; border-color:red" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="DriverDetails.aspx?driverId=<%#:Item.DriverId %>">
                                        <span>
                                            <%#:Item.DriverName %>
                                        </span>
                                    </a>
                                    <br />
                                    <a href="DriverDetails.aspx?driverId=?<%#:Item.DriverId %>">
                                        <span>
                                            <b>Championship Points: </b><%#:Item.DriverPoints %>
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

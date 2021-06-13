<%@ Page Title="Driver Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DriverDetails.aspx.cs" Inherits="WingTipToysMSDN.DriverDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="driverDetail" runat="server" ItemType="WingTipToysMSDN.Models.Driver" SelectMethod="GetDriver" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.DriverName %></h1>
            </div>
            <br />
            <table style="font-size:larger">
                <tr>
                    <td>
                        <img src="<%#:Item.ImagePath %>" style="border:solid; border-color:red" alt="<%#:Item.DriverName %>" width="860" height="860"/>
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <span style="font-size:large">Team:&nbsp;<%#:Item.Team.TeamName %></span>
                        <br />
                        <br />
                        <span  style="font-weight:200">Wins:&nbsp;<%#:Item.Wins %></span>
                        <br />
                        <br />
                        <span>Podiums:&nbsp;<%#:Item.Podiums %></span>
                        <br />
                        <br />
                        <span>Highest Finish:&nbsp;<%#:Item.HighestFinish %></span>
                        <br />
                        <br />
                        <span>Grand Prix Starts:&nbsp;<%#:Item.RaceStarts %></span>
                        <br />
                        <br />
                        <span style="font-weight:200">World Championships:&nbsp;<%#:Item.WorldChampionships %></span>
                        <br />
                        <br />
                        <span style="font-size:xx-large">Current Position:&nbsp;<%#:WingTipToysMSDN.DriverDetails.GetDriverPosition(Item.DriverId)%></span>
                        <br />
                        <span  style="font-weight:300">Championship Points: </span>&nbsp;<%#:Item.DriverPoints %>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>

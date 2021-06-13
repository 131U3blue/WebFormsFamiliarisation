<%@ Page Title="Add Race Results" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="WingTipToysMSDN.Calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup>
        <h2><%#:Page.Title %></h2>
        <h4>Choose a Track Below</h4>
    </hgroup>
    <asp:ListView ID="trackList" runat="server" 
        DataKeyNames="TrackId" GroupItemCount="3" 
        ItemType="WingTipToysMSDN.Models.Track" SelectMethod="GetTracks">
        <EmptyDataTemplate>
            <table>
                <tr>
                    <td>No Tracks Found!</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <GroupTemplate>
            <tr id="ItemPlaceholderContainer" runat="server">
                <td id="ItemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <ItemTemplate>
            <td runat="server">
                <table class="table table-dark">
                    <tr>                        
                        <td style="background-color:#060606">                            
                            <h4<%#:Item.TrackId %>">
                                <span style="font-size:large"><%#:Convert.ToString(Item.RaceDate.ToShortDateString())%></span>
                            </h4>                            
                            <a href="Calendar.aspx?trackId=<%#:Item.TrackId%>">
                            <h3 <%#:Item.TrackId%>">
                                <span style="font-size:larger"><%#:Item.TrackName %></span>
                            </h3>
                            </a>
                            <h4 <%#:Item.TrackId %>">
                                <span style="font-size:large"><%#:Item.Country %></span>
                            </h4>
                            <a href="AddResults.aspx?trackId=<%#:Item.TrackId %>">
                                <asp:Button OnClick="addResultsBtn_Click" BackColor='<%#(Item.RaceDate <= DateTime.Now)?System.Drawing.Color.Red:System.Drawing.Color.Gray %>'
                                    ID="addResultsBtn" runat="server" Text="Add Results" Enabled="<%#(Item.RaceDate <= DateTime.Now)%>" />
                            </a>
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
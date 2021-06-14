<%@ Page Title="Add Race Results" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddResults.aspx.cs" Inherits="WingTipToysMSDN.AddResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%#: Page.Title %></h1>
    <asp:Repeater ID="DriverRepeater" OnItemDataBound="DriverRepeater_OnItemDataBound" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr>
                    <th style="width: 100px"><b>Position</b></th>
                    <th><b>Driver</b></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
                <tr>
                    <td style="color:aliceblue" runat="server"><%# DataBinder.Eval(Container.DataItem, "DriverId") %> </td>
                    <td style="width:500px">
                        <asp:DropDownList ID="ddList" AutoPostBack="false" BackColor="Black" runat="server">
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
<%--                    <select style="background-color:black; width:500px">
                            <option value="" disabled selected hidden>Choose a driver</option>
                            <option value="1">Lewis Hamilton</option>
                            <option value="2">Valtteri Bottas</optionv>
                            <option value="3">Max Verstappen</option>
                            <option value="4">Sergio Perez</option>
                            <option value="5">Lando Norris</option>
                            <option value="6">Daniel Ricciardo</option>
                            <option value="7">Charles Leclerc</option>
                            <option value="8">Carlos Sainz</option>
                            <option value="9">Pierre Gasly</option>
                            <option value="10">Yuki Tsunoda</option>
                            <option value="11">Sebastian Vettel</option>
                            <option value="12">Lance Stroll</option>
                            <option value="13">Fernando Alonso</option>
                            <option value="14">Esteban Ocon</option>
                            <option value="15">Antonio Giovinazzi</option>
                            <option value="16">Kimi Raikkonen</option>
                            <option value="17">Mick Schumacher</option>
                            <option value="18">Nikita Mazepin</option>
                            <option value="19">George Russell</option>
                            <option value="20">Nicholas Latifi</option>
                        </select>--%>
                    </td>
                </tr>
        </ItemTemplate>
        <FooterTemplate>
            <tr>
                <td style="background-color:black"></td>
                <td>
                    <asp:Button id="SubmitBtn" runat="server" Text="Submit" onclick="SubmitBtn_CheckAndSubmitResults" type="submit" style="width:500px; background-color:red; align-self:center"></asp:Button>
                </td>
            </tr>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

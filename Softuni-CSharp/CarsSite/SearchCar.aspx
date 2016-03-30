<%@ Page Title="Търсене" Language="C#" AutoEventWireup="true" CodeFile="SearchCar.aspx.cs" Inherits="SearchCar" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Търси автомобил</h2>
    <br />
    Вносител:&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Importers" 
        DataTextField="importer" DataValueField="importer">
    </asp:DropDownList>
    <asp:SqlDataSource ID="Importers" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT [importer] FROM [Importers]"></asp:SqlDataSource>
    <br />
    <br />
    Описание:&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" MaxLength="20"></asp:TextBox>
&nbsp;
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
        ForeColor="#CC0000"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Търси" />

</asp:Content>
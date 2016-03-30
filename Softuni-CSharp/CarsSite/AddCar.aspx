<%@ Page  Title="Добави кола" Language="C#" AutoEventWireup="true" CodeFile="AddCar.aspx.cs" Inherits="AddCar" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            height: 47px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Добави нов автомобил
    </h2>

    <table style="height: 94px">
        <tr>
            <td class="style1">Марка:&nbsp;
    <asp:TextBox ID="tb_brand" runat="server"></asp:TextBox></td>
            <td class="style1"> Мощност:
    <asp:TextBox ID="tb_hp" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> Година:&nbsp; 
    <asp:TextBox ID="tb_year" runat="server" MaxLength="4"></asp:TextBox></td>
            <td> Вносител:  
    <asp:TextBox ID="tb_importer" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    Описание:

    <asp:TextBox ID="tb_decrtiption" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Добави в базата" />
    <br />
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
        ForeColor="#006600"></asp:Label>

</asp:Content>

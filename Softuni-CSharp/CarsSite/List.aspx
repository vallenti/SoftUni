<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="CarLists" MasterPageFile="~/Site.master" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
       
        <h2>Мечтани автомобили</h2>
        &nbsp;&nbsp;
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
            Width="405px" 
            ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" 
            AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Марка"  DataField="brand" Visible="true"/>
                <asp:BoundField HeaderText="Година" DataField="year" Visible="true" />
                <asp:BoundField HeaderText="Мощност" DataField="hp" Visible="true" />
                <asp:BoundField HeaderText="Вносител" DataField="importer" Visible="true"/>
                <asp:TemplateField HeaderText="Описaние">
                     <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("description").ToString().HighlightKeyWords(Session["description"].ToString(), "yellow", false) %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#789048" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#789048" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#C0D860" ForeColor=#604848 HorizontalAlign="Center" Font-Bold=true />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="CarDB" runat="server">
        </asp:SqlDataSource>
</asp:Content>
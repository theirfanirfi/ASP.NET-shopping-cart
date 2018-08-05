<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-MasterPage.master" AutoEventWireup="true" CodeFile="editProduct.aspx.cs" Inherits="Admin_editProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label">Product Name: </asp:Label>
        <asp:TextBox ID="productNamee" runat="server" CssClass="form-control"></asp:TextBox><br />
           <asp:Label ID="Label2" runat="server" Text="Label">Product Price: </asp:Label>
          <asp:TextBox ID="productPricee" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:TextBox ID="productId" runat="server" Visible="false"/>
        <asp:Image runat="server" ID="img" Width="200" Height="200" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:DropDownList CssClass="form-control" ID="cat_idd" runat="server" DataSourceID="catpDataSource1" DataTextField="cat_name" DataValueField="Id"></asp:DropDownList>
        <asp:SqlDataSource ID="catpDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [category_tbl]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1p" runat="server" Text="Update Product" CssClass="btn btn-success" OnClick="Button1p_Click"/>
        <br />
        <br />
        </form>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-MasterPage.master" AutoEventWireup="true" CodeFile="addproduct.aspx.cs" Inherits="Admin_addproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label">Product Name: </asp:Label>
        <asp:TextBox ID="productName" runat="server" CssClass="form-control"></asp:TextBox><br />
           <asp:Label ID="Label2" runat="server" Text="Label">Product Price: </asp:Label>
          <asp:TextBox ID="productPrice" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:DropDownList CssClass="form-control" ID="cat_id" runat="server" DataSourceID="catpDataSource1" DataTextField="cat_name" DataValueField="Id"></asp:DropDownList>
        <asp:SqlDataSource ID="catpDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [category_tbl]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1p" runat="server" Text="Add Product" CssClass="btn btn-success" OnClick="Button1p_Click" />
        <br />
        <br />
        </form>
</asp:Content>


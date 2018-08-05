<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-MasterPage.master" AutoEventWireup="true" CodeFile="addcategory.aspx.cs" Inherits="Admin_addcategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label">Category Name: </asp:Label>
        <asp:TextBox ID="categoryName" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Add Category" CssClass="btn btn-success" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:GridView CssClass="table table-bordered table-condensed table-hover table-responsive" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="CategoriesDataSource" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="cat_name" HeaderText="Category" SortExpression="cat_name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="CategoriesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [category_tbl] ORDER BY [Id] DESC"></asp:SqlDataSource>
    </form>
</asp:Content>


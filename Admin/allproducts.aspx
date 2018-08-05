<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin-MasterPage.master" AutoEventWireup="true" CodeFile="allproducts.aspx.cs" Inherits="Admin_allproducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
    <asp:GridView OnRowUpdated="GridView1_RowUpdated" ID="GridView1" CssClass="table table-hover table-bordered table-condensed tale-striped table-responsive" runat="server" DataKeyNames="Id" AutoGenerateColumns="False" DataSourceID="AllProductsSqlDataSource" AllowPaging="True" AllowSorting="True" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" Visible="false"  />
            <asp:BoundField DataField="product_name" HeaderText="Product Title" SortExpression="product_name" />
            <asp:BoundField DataField="product_price" HeaderText="Product Price" SortExpression="product_price" />
            <asp:ImageField DataImageUrlField="product_image" ControlStyle-Height="60" ControlStyle-Width="100" HeaderText="Product Image" SortExpression="product_image" />
            <asp:BoundField DataField="cat_name" HeaderText="Category" SortExpression="cat_name" />
            <asp:HyperLinkField Text="Update" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="editProduct.aspx?eid={0}" HeaderText="Update"/>
               <asp:CommandField ShowEditButton="true" />  
              <asp:CommandField ShowDeleteButton="true" />

        </Columns>
    </asp:GridView>
        </form>
    <asp:SqlDataSource ID="AllProductsSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT product_tbl.Id, product_tbl.product_name, product_tbl.product_price, product_tbl.product_image, product_tbl.cat_id, category_tbl.Id AS Expr1, category_tbl.cat_name FROM product_tbl LEFT OUTER JOIN category_tbl ON product_tbl.cat_id = category_tbl.Id"
        DeleteCommand="DELETE FROM product_tbl WHERE Id = @Id"
        UpdateCommand="UPDATE product_tbl SET product_name = [product_name], product_price = [product_price] WHERE Id = @Id"
        ></asp:SqlDataSource>
</asp:Content>


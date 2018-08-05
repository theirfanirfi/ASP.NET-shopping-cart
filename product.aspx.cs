using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class product : System.Web.UI.Page
{
    String PRODUCT_ID = "";
    MyConnection con = new MyConnection();
    SqlDataReader dr;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        PRODUCT_ID = Request.QueryString["pid"];

        string query = "SELECT * FROM product_tbl WHERE Id = '" + PRODUCT_ID + "'";
        dr = con.fetch(query);
        dr.Read();
        //Response.Write("<script>alert('" + dr["product_name"].ToString() + "');</script>");
        producttitle.InnerText = dr["product_name"].ToString();
        productprice.InnerText = "$" + dr["product_price"].ToString();
        //productdescription.InnerText = dr["product_description"].ToString();
        con.con.Close();

    }
    protected void sub_Click(object sender, EventArgs e)
    {
        string name = rname.Text;
        string email = remail.Text;
        string com = textarea.Text;
        string query = "INSERT INTO product_review(rev_name,rev_email,rev_comments) VALUES('"+name+"','"+email+"','"+com+"')";
        string r = con.insert(query);
        Response.Write("<script>alert('" + r + "');</script>");
    }
}
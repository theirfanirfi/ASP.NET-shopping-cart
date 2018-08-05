using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_addcategory : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Irfan Ullah\Documents\Visual Studio 2012\WebSites\ShoppingCart\App_Data\shoppingcartdatabase.mdf;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string catname = categoryName.Text;
        string query = "INSERT INTO category_tbl(cat_name) VALUES('" + catname + "')";
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                Response.Write("<script>alert('Category Added');</script>");
                Response.Redirect("addcategory.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('"+ex.ToString()+"');</script>");
        }
        finally
        {
            con.Close();
        }
       
    }
}
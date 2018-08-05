using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_editProduct : System.Web.UI.Page
{
    String PRODUCT_ID = "";
    MyConnection con = new MyConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        PRODUCT_ID = Request.QueryString["eid"];

        SqlDataReader dr = con.fetch("SELECT * FROM product_tbl LEFT JOIN category_tbl ON product_tbl.cat_id = category_tbl.Id WHERE product_tbl.Id = '"+PRODUCT_ID+"'");
        
        dr.Read();
        productNamee.Text = dr["product_name"].ToString();
        productPricee.Text = dr["product_price"].ToString();
        cat_idd.SelectedValue = dr["cat_id"].ToString();
        img.ImageUrl = dr["product_image"].ToString();
        productId.Text = dr["Id"].ToString();
        //Response.Write("<script>alert('" + dr["product_name"].ToString() + "');</script>");
        con.con.Close();

    }
    protected void Button1p_Click(object sender, EventArgs e)
    {
        String pname = productNamee.Text.ToString();
        string pprice = productPricee.Text.ToString();
        string catId = cat_idd.SelectedValue;
        string url = img.ImageUrl;
        string pid = productId.Text;
        string filename = FileUpload1.FileName;
        Response.Write("<script>alert('" + productNamee.Text.ToString() + " : " + pprice + " : " + catId + " : " + filename + " : " + pid + "');</script>");
        //FileUpload1.PostedFile.SaveAs(Server.MapPath("uploads/" + filename));
        //string imagepath = "~/Admin/uploads/" + filename.ToString();

        //string query = "UPDATE product_tbl SET product_name ='" + pname + "', product_price= '" + pprice + "', cat_id = '" + catId + "', product_image = '" + imagepath + "' WHERE Id = '"+pid+"'";
        //string msg = con.insert(query);
        //if (msg.Equals(""))
        //{
        //    Response.Write("<script>alert('Record Not updated');</script>");
        //}
        //else
        //{
        //    Response.Write("<script>alert('Record updated');</script>");
        //    string uri = string.Format("editProduct.aspx?eid={0}", pid);
        //    Response.Redirect(uri);

        //}
    }
}
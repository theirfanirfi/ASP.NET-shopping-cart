using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_addproduct : System.Web.UI.Page
{
    MyConnection con = new MyConnection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1p_Click(object sender, EventArgs e)
    {
        string pname = productName.Text;
        string pprice = productPrice.Text;
        string filename = FileUpload1.FileName;
        FileUpload1.PostedFile.SaveAs(Server.MapPath("uploads/"+filename));
        string image = "~/Admin/uploads/" + filename.ToString();
        string catId = cat_id.SelectedValue;

        string query = "INSERT INTO product_tbl(product_name,product_price,product_image,cat_id) VALUES('"+pname+"','"+pprice+"','"+image+"','"+catId+"')";
        string st = con.insert(query);
        Response.Write("<script>alert('"+st+"');</script>");


    }
}
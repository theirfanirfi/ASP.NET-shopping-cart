using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class item
{
    private string ID;

    public string Id
    {
       get { return ID; } 
       set { ID = value; }
    }
}

public partial class addtocart : System.Web.UI.Page
{
    string PID = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            PID = Request.QueryString["pid"];
            if (Session["cart"] == null)
            {
                List<item> list = new List<item>();
                item itm = new item();
                itm.Id = PID;
                list.Add(itm);
                Session["cart"] = list;
                Session["count"] = list.ToList().Count;
                Response.Redirect("Default.aspx");

            }
            else
            {

                List<item> listc = (List<item>)Session["cart"];
                item itm = new item();
                itm.Id = PID;
                listc.Add(itm);
                Session["cart"] = listc;
                Session["count"] = listc.ToList().Count;
                Response.Redirect("Default.aspx");


            }

            List<item> g = (List<item>)Session["cart"];

            GridView1.DataSource = g;
            GridView1.DataBind();


        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('catch" + ex.ToString() + "');</script>");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for MyConnection
/// </summary>
public class MyConnection
{
    public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Irfan Ullah\Documents\Visual Studio 2012\WebSites\ShoppingCart\App_Data\shoppingcartdatabase.mdf;Integrated Security=True");
    SqlDataReader dr;
    public MyConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string insert(String query)
    {
        String r = "";
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                r = "Product Added successfully.";
            }
        }
        catch (Exception ex)
        {
            r = ex.ToString();
            
        }
        finally
        {
            con.Close();
        }
        return r;
    }

    public SqlDataReader fetch(String query)
    {
        
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                 dr = com.ExecuteReader();
                
            }
        }
        catch (Exception ex)
        {
        }
        finally
        {
            //con.Close();
        }

        return dr;
       
    }
}
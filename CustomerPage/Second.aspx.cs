using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

public partial class Secong : System.Web.UI.Page
{
    MySqlConnection con;
    MySqlCommand cmd;
    MySqlDataAdapter da1,da2;
    DataSet ds1 = new DataSet();
    DataSet ds2 = new DataSet();
    String str, res;
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
        con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
        con.Open();
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("Summary.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
           
            if(!String.IsNullOrWhiteSpace(TextBox1.Text)&& !String.IsNullOrWhiteSpace(TextBox2.Text)&& !String.IsNullOrWhiteSpace(TextBox3.Text)&&(!String.IsNullOrWhiteSpace(TextBox4.Text)|| !String.IsNullOrWhiteSpace(TextBox5.Text)|| !String.IsNullOrWhiteSpace(TextBox6.Text)|| !String.IsNullOrWhiteSpace(TextBox7.Text)))
            {
                DateTime date = DateTime.Now;
                String time = date.ToLongTimeString();
                str = "insert into pizza.customerdetails(Name,Phone_no,Email_ID,Address) values('" + this.TextBox1.Text + "','" + this.TextBox2.Text + "','" + this.TextBox3.Text + "','" + this.TextBox4.Text + this.TextBox5.Text + this.TextBox6.Text + this.TextBox7.Text + "');";
                cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("Select Name from CustomerDetails", con);
                da1 = new MySqlDataAdapter(cmd);
                da1.Fill(ds1);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("Select Name,size,count from items", con);
                da2 = new MySqlDataAdapter(cmd);
                da2.Fill(ds2);
                cmd.ExecuteNonQuery();

                if (!object.Equals(ds2.Tables[0], null))
                {
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                        {
                            res += Convert.ToString(ds2.Tables[0].Rows[i]["Name"]) + "," + Convert.ToString(ds2.Tables[0].Rows[i]["size"]) + "," + Convert.ToString(ds2.Tables[0].Rows[i]["count"]);
                            res += "/";
                        }
                    }
                }
                cmd = new MySqlCommand("insert into deliveryboy(CustomerName,Address)values('" + this.TextBox1.Text + "','" + this.TextBox4.Text + this.TextBox5.Text + this.TextBox6.Text + this.TextBox7.Text + "');", con);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("insert into pizza.chef(CustomerName,Items,OrderedTime) values('" + this.TextBox1.Text + "','" + res + "','" + time + "');", con);
                cmd.ExecuteNonQuery();              
                con.Close();
                Response.Redirect("Final.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Enter all details');", true);
            }
        
       
        
       
    }



    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}

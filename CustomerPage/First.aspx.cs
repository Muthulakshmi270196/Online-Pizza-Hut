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

public partial class Default2 : System.Web.UI.Page
{
    int inc_count, dec_count;
    int total;
    MySqlConnection con;
    MySqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new MySqlConnection("Data Source=localhost;Database=pizza;User ID=root;Password=database");
        con.Open();
        cmd = new MySqlCommand("truncate table CustomerDetails",con);
        cmd.ExecuteNonQuery();
        cmd = new MySqlCommand("truncate table Items",con);
        cmd.ExecuteNonQuery();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox3.Text);
        
        TextBox3.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total+ 300;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox1.Text);
        TextBox1.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 100;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox5.Text);
        TextBox5.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 100;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox6.Text);
        TextBox6.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 200;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox20.Text);
        TextBox20.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 200;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox2.Text);
        TextBox2.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 200;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox7.Text);
        TextBox7.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 300;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox8.Text);
        TextBox8.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 100;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox10.Text);
        TextBox10.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 300;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox11.Text);
        TextBox11.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 100;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button21_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox12.Text);
        TextBox12.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 200;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button23_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox13.Text);
        TextBox13.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 300;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button25_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox14.Text);
        TextBox14.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 100;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button27_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox15.Text);
        TextBox15.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 200;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button29_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox16.Text);
        TextBox16.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 300;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button31_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox17.Text);
        TextBox17.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 100;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button33_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox18.Text);
        TextBox18.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 200;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button35_Click(object sender, EventArgs e)
    {
        inc_count = Convert.ToInt32(TextBox19.Text);
        TextBox19.Text = Convert.ToString(inc_count+1);
        total = Convert.ToInt32(TextBox4.Text);
        total = total + 300;
        TextBox4.Text = Convert.ToString(total);
    }
    protected void Button6_Click1(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox3.Text);
        if (dec_count > 0)
        {
            TextBox3.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 300;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox1.Text);
        if (dec_count > 0)
        {
            TextBox1.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 100;
            TextBox4.Text = Convert.ToString(total);
        }
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox2.Text);
        if (dec_count > 0)
        {
            TextBox2.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 200;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox5.Text);
        if (dec_count > 0)
        {
            TextBox5.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 100;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox6.Text);
        if (dec_count > 0)
        {
            TextBox6.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 200;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox7.Text);
        if (dec_count > 0)
        {
            TextBox7.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 300;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox8.Text);
        if (dec_count > 0)
        {
            TextBox8.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 100;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox20.Text);
        if (dec_count > 0)
        {
            TextBox20.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 200;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox10.Text);
        if (dec_count > 0)
        {
            TextBox10.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 300;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox11.Text);
        if (dec_count > 0)
        {
            TextBox11.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 100;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button22_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox12.Text);
        if (dec_count > 0)
        {
            TextBox12.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 200;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button24_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox13.Text);
        if (dec_count > 0)
        {
            TextBox13.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 300;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button26_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox14.Text);
        if (dec_count > 0)
        {
            TextBox14.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 100;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button28_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox15.Text);
        if (dec_count > 0)
        {
            TextBox15.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 200;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button30_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox16.Text);
        if (dec_count > 0)
        {
            TextBox16.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 300;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button32_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox17.Text);
        if (dec_count > 0)
        {
            TextBox17.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 100;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button34_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox18.Text);
        if (dec_count > 0)
        {
            TextBox18.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 200;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void Button36_Click(object sender, EventArgs e)
    {
        dec_count = Convert.ToInt32(TextBox19.Text);
        if (dec_count > 0)
        {
            TextBox19.Text = Convert.ToString(dec_count - 1);
            total = Convert.ToInt32(TextBox4.Text);
            total = total - 300;
            TextBox4.Text = Convert.ToString(total);
        }
    }
    protected void TextBox11_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox20_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button37_Click(object sender, EventArgs e)
    {
        if (TextBox4.Text != "0")
        {
            if (TextBox1.Text != "0")
            {
                int count = Convert.ToInt32(TextBox1.Text);
                cmd = new MySqlCommand("Insert into Items values('PanneerPizza','Small','" + count + "',100,'" + (count * 100) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox2.Text != "0")
            {
                int count = Convert.ToInt32(TextBox2.Text);
                cmd = new MySqlCommand("Insert into Items values('PanneerPizza','Medium','" + count + "',200,'" + (count * 200) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox3.Text != "0")
            {
                int count = Convert.ToInt32(TextBox3.Text);
                cmd = new MySqlCommand("Insert into Items values('PanneerPizza','Large','" + count + "',300,'" + (count * 300) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox5.Text != "0")
            {
                int count = Convert.ToInt32(TextBox5.Text);
                cmd = new MySqlCommand("Insert into Items values('VegPizza','Small','" + count + "',100,'" + (count * 100) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox6.Text != "0")
            {
                int count = Convert.ToInt32(TextBox6.Text);
                cmd = new MySqlCommand("Insert into Items values('VegPizza','Medium','" + count + "',200,'" + (count * 200) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox7.Text != "0")
            {
                int count = Convert.ToInt32(TextBox7.Text);
                cmd = new MySqlCommand("Insert into Items values('VegPizza','Large','" + count + "',300,'" + (count * 300) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox8.Text != "0")
            {
                int count = Convert.ToInt32(TextBox8.Text);
                cmd = new MySqlCommand("Insert into Items values('ChickenPizza','Small','" + count + "',100,'" + (count * 100) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox20.Text != "0")
            {
                int count = Convert.ToInt32(TextBox20.Text);
                cmd = new MySqlCommand("Insert into Items values('ChickenPizza','Medium','" + count + "',200,'" + (count * 200) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox10.Text != "0")
            {
                int count = Convert.ToInt32(TextBox10.Text);
                cmd = new MySqlCommand("Insert into Items values('ChickenPizza','Large','" + count + "',300,'" + (count * 300) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox11.Text != "0")
            {
                int count = Convert.ToInt32(TextBox11.Text);
                cmd = new MySqlCommand("Insert into Items values('SausagePizza','Small','" + count + "',100,'" + (count * 100) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox12.Text != "0")
            {
                int count = Convert.ToInt32(TextBox12.Text);
                cmd = new MySqlCommand("Insert into Items values('SausagePizza','Medium','" + count + "',200,'" + (count * 200) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox13.Text != "0")
            {
                int count = Convert.ToInt32(TextBox13.Text);
                cmd = new MySqlCommand("Insert into Items values('SausagePizza','Large','" + count + "',300,'" + (count * 300) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox14.Text != "0")
            {
                int count = Convert.ToInt32(TextBox14.Text);
                cmd = new MySqlCommand("Insert into Items values('DoubleCheesePizza','Small','" + count + "',100,'" + (count * 100) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox15.Text != "0")
            {
                int count = Convert.ToInt32(TextBox15.Text);
                cmd = new MySqlCommand("Insert into Items values('DoubleCheesePizza','Medium','" + count + "',200,'" + (count * 200) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox16.Text != "0")
            {
                int count = Convert.ToInt32(TextBox16.Text);
                cmd = new MySqlCommand("Insert into Items values('DoubleCheesePizza','Large','" + count + "',300,'" + (count * 300) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox17.Text != "0")
            {
                int count = Convert.ToInt32(TextBox17.Text);
                cmd = new MySqlCommand("Insert into Items values('MexicanGreenWave','Small','" + count + "',100,'" + (count * 100) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox18.Text != "0")
            {
                int count = Convert.ToInt32(TextBox18.Text);
                cmd = new MySqlCommand("Insert into Items values('MexicanGreenWave','Medium','" + count + "',200,'" + (count * 200) + "');", con);
                cmd.ExecuteNonQuery();
            }
            if (TextBox19.Text != "0")
            {
                int count = Convert.ToInt32(TextBox19.Text);
                cmd = new MySqlCommand("Insert into Items values('MexicanGreenWave','Large','" + count + "',300,'" + (count * 300) + "');", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            
            Response.Redirect("Summary.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('You should add items to Place order');", true);
        }
    }



    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}

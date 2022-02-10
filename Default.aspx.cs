using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void FizzBuzzButton_Click(object sender, EventArgs e)
    {

        //string r = "";
        for (int i = 1; i <= 100; i++)
        {
            TextBox txt = new TextBox();
            txt.ID = "textBox1";

            if (i % 3 == 0 && i % 5 == 0)
            {
                TextBox a = new TextBox();
                txt.Text = "\nFizzBuzz";
            }
            else if (i % 3 == 0)
            {
                TextBox b = new TextBox();
                txt.Text = "\nFizz";
            }
            else if (i % 5 == 0)
            {
                TextBox c = new TextBox();
                txt.Text = "\n" + i + "\tBuzz";
            }
            else
            {
                TextBox d = new TextBox();
                txt.Text = "\n" + i;
            }
            form1.Controls.Add(txt);
        }
        Button clear = new Button();
        clear.Text = "Clear";
        clear.Width = FizzBuzzButton.Width;
        clear.Height = FizzBuzzButton.Height;
        clear.BackColor = FizzBuzzButton.BackColor;
        form1.Controls.Add(clear);

    }
    protected void clear_Click(object sender, EventArgs e)
    {
        form1.Controls.Clear();
        form1.Controls.Add(FizzBuzzButton);
    }
}
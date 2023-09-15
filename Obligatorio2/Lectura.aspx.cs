using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class Lectura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath(".") + "/archivo.txt"))
            {
                StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/archivo.txt");

                string[] lineas = (streamReader.ReadToEnd()).Split('\n');
                streamReader.Close();
                Label1.Text = "<hr>";
                int lineCount = 0;
                foreach (string l in lineas)
                {
                    lineCount++;
                    if (lineCount % 4 == 0)
                    {
                        Label1.Text += $"{l} <br/>";
                        Label1.Text += "<hr> ";
                    }
                    else
                    {
                        Label1.Text += $"{l} <br/>";
                    }
                }
            }
            else
                Label1.Text = "No existen datos";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}
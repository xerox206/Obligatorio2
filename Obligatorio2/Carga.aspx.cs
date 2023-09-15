using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio2
{
    public partial class Carga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Atras_Click(object sender, EventArgs e)
        { 
            Response.Redirect("Menu.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter($"{Server.MapPath(".")}/archivo.txt",true);
            streamWriter.WriteLine(TextBox1.Text);
            streamWriter.WriteLine(TextBox2.Text);
            streamWriter.WriteLine(TextBox3.Text);
            streamWriter.WriteLine(TextBox4.Text);
            streamWriter.Close();
            Label1.Text = $"Cargado exitosamente, ruta {Server.MapPath(".")}.";

        }
    } 
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.localhost;

namespace WebApplication1
{
    public partial class Login1 : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        public string DBpath = HttpRuntime.AppDomainAppPath + "dataBase.db";
        public WebService1 ws;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["authentication"] = false;
            Session["id"] = null;
            ws = new WebService1();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int user = Int32.Parse(TextBox1.Text);

                dt = ws.LoginRecepcionist(user);

                foreach (DataRow dr in dt.Rows)
                {
                    string pass = TextBox2.Text;

                    using (MD5 md5Hash = MD5.Create())
                    {
                        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
                        pass = BitConverter.ToString(data).Replace("-", string.Empty);
                    }

                    string passBD = dr["pass"].ToString();

                    using (MD5 md5Hash = MD5.Create())
                    {
                        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(passBD));
                        passBD = BitConverter.ToString(data).Replace("-", string.Empty);
                    }

                    if (pass == passBD)
                    {
                        Session["authentication"] = true;
                        Session["id"] = dr["id"].ToString();
                        Response.Redirect("./admin/HomeAdmin.aspx");
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int user = Int32.Parse(TextBox3.Text);

                dt = ws.LoginClient(user);

                foreach (DataRow dr in dt.Rows)
                {
                    string pass = TextBox4.Text;

                    using (MD5 md5Hash = MD5.Create())
                    {
                        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
                        pass = BitConverter.ToString(data).Replace("-", string.Empty);
                    }

                    string passBD = dr["pass"].ToString();

                    using (MD5 md5Hash = MD5.Create())
                    {
                        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(passBD));
                        passBD = BitConverter.ToString(data).Replace("-", string.Empty);
                    }

                    if (pass == passBD)
                    {
                        {
                            Session["authentication"] = true;
                            Session["id"] = dr["id"].ToString();
                            Response.Redirect("./client/HomeClient.aspx");
                        }

                    }
                }
            }
            catch (Exception)
            {

            }


        }
    }
}
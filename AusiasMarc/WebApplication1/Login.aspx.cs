using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using WebApplication1.localhost;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {

        public DataTable dt = new DataTable();
        public string DBpath = HttpRuntime.AppDomainAppPath + "dataBase.db";
        public WebService1 ws;

        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService1();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int user = Int32.Parse(TextBox1.Text);

            dt = ws.LoginRecepcionist(user);

            foreach (DataRow dr in dt.Rows)
            {
                if (TextBox2.Text == dr["pass"].ToString())
                {
                    Response.Redirect("./admin/Home.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            int user = Int32.Parse(TextBox3.Text);

            dt = ws.LoginClient(user);

            foreach (DataRow dr in dt.Rows)
            {
                if (TextBox4.Text == dr["pass"].ToString()){
                    Response.Redirect("./client/Home.aspx");
                }
                
            }
        }
    }
}
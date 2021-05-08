using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.localhost;

namespace WebApplication1.admin
{
    public partial class Home : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        public string DBpath = HttpRuntime.AppDomainAppPath + "dataBase.db";
        public WebService1 ws;
        String id;

        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService1();
            this.id = String.IsNullOrEmpty(Request.QueryString["id"]) ? "" : Request.QueryString["id"].ToString();

            dt = ws.DataRecepcionist(Int32.Parse(id));

            foreach (DataRow dr in dt.Rows)
            {
                Label1.Text = dr["idn"].ToString();
                Label1.Text += " " + dr["name"].ToString();

            }
        }
    }
}
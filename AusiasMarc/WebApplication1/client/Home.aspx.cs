using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.localhost;

namespace WebApplication1.client
{
    public partial class Home : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        public string DBpath = HttpRuntime.AppDomainAppPath + "dataBase.db";
        public WebService1 ws;
        String id, nameClient;


        protected void Page_Load(object sender, EventArgs e)
        { 
            ws = new WebService1();
            this.id = String.IsNullOrEmpty(Request.QueryString["id"]) ? "" : Request.QueryString["id"].ToString();

            dt = ws.DataClient(Int32.Parse(id));

            foreach (DataRow dr in dt.Rows)
            {
                Label1.Text = dr["idn"].ToString();
                nameClient= dr["name"].ToString();
                Label1.Text += " " + nameClient + " " + dr["surname"].ToString();
            }

            dt = ws.DataReserve(Int32.Parse(id), 0);

            String reserve;

            foreach (DataRow dr in dt.Rows)
            {

                reserve = nameClient + "\t";

                dt = ws.DataRecepcionist(Int32.Parse(dr["idRecepcionist"].ToString()));

                foreach (DataRow dr1 in dt.Rows)
                {
                    reserve += dr1["name"].ToString() + "\t";
                }

                reserve += dr["arrivalDate"].ToString() + "\t";
                reserve += dr["finishDate"].ToString() + "\t";
                reserve += dr["typeRoom"].ToString() + "\t";

                Reservas.Items.Add(reserve);
            }
        }
    }
}
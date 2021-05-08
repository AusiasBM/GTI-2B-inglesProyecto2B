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
        String id, nameRecepcionist;

        protected void Page_Load(object sender, EventArgs e)
        {
            ws = new WebService1();
            this.id = String.IsNullOrEmpty(Request.QueryString["id"]) ? "" : Request.QueryString["id"].ToString();

            dt = ws.DataRecepcionist(Int32.Parse(id));

            foreach (DataRow dr in dt.Rows)
            {
                id = dr["id"].ToString();
                nameRecepcionist = dr["name"].ToString();
            }


            dt = ws.DataReserve(Int32.Parse(id), 1);

            String reserve;

            foreach (DataRow dr in dt.Rows)
            {

                reserve = nameRecepcionist + "\t";

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
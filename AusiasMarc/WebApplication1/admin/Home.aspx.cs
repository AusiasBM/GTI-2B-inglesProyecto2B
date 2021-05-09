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

        protected void ReservasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientTextBox.Text = ReservasList.SelectedItem.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!(bool)Session["authentication"])
            {
                Response.Redirect("../Login.aspx");
            }

            ReservasList.Items.Clear();

            ws = new WebService1();
            this.id = Session["id"].ToString();

            dt = ws.DataRecepcionist(Int32.Parse(id));

            foreach (DataRow dr in dt.Rows)
            {
                id = dr["id"].ToString();
                idnLabel.Text = dr["idn"].ToString();
                nameRecepcionist = dr["name"].ToString();
                nameLabel.Text = nameRecepcionist + " " + dr["surname"].ToString();
            }

            dt = ws.DataReserve(Int32.Parse(id), 1);


            List<Reserva> reservas = new List<Reserva>();

            foreach (DataRow dr in dt.Rows)
            {

                dt = ws.DataClient(Int32.Parse(dr["idClient"].ToString()));

                foreach (DataRow dr1 in dt.Rows)
                {
                    Reserva reserva = new Reserva(dr["id"].ToString(), nameRecepcionist, dr1["name"].ToString(), dr["arrivalDate"].ToString(), dr["finishDate"].ToString(), dr["typeRoom"].ToString());
                    ReservasList.Items.Add(reserva.ToString());
                }
            }

        }
    }
}
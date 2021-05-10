using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.localhost;

namespace WebApplication1.admin
{
    public partial class HomeAdmin : System.Web.UI.Page
    {
        public DataTable dt = new DataTable();
        public string DBpath = HttpRuntime.AppDomainAppPath + "dataBase.db";
        public WebService1 ws;
        String id, nameRecepcionist;
        List<Reserva> reservas = new List<Reserva>();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!(bool)Session["authentication"])
                {
                    Response.Redirect("../Login.aspx");
                }
            }
            catch (Exception)
            {
                Response.Redirect("../Login.aspx");
            }
            

            ws = new WebService1();
            this.id = Session["id"].ToString();

            infoRecepcionist();

        }

        protected void searchButtonReserve_Click(object sender, EventArgs e)
        {

            dt = ws.DataReserveId(Int32.Parse(idReserveTextBox.Text), Int32.Parse(id));

            foreach (DataRow dr in dt.Rows)
            {
                clientTextBox.Text = dr["idClient"].ToString();
                arrivalDateTextBox.Text = dr["arrivalDate"].ToString();
                finishDateTextBox.Text = dr["finishDate"].ToString();
                typeRoomTextBox.Text = dr["typeRoom"].ToString();
            }

            if(dt.Rows.Count != 0)
            {
                noticeReserveLabel.Text = "";
            }
            else
            {
                clientTextBox.Text = "";
                arrivalDateTextBox.Text = "";
                finishDateTextBox.Text = "";
                typeRoomTextBox.Text = "";
                noticeReserveLabel.Text = "No exist the id of reserve";
            }


        }

        protected void searchButtonClient_Click(object sender, EventArgs e)
        {
            dt = ws.allClients(Int32.Parse(idClientTextBox.Text));

            foreach (DataRow dr in dt.Rows)
            {
                idnTextBox.Text = dr["idn"].ToString();
                nameTextBox.Text = dr["name"].ToString();
                surnameTextBox.Text = dr["surname"].ToString();
                passTextBox.Text = dr["pass"].ToString();
                creditcardTextBox.Text = dr["creditcard"].ToString();
            }

            if (dt.Rows.Count != 0)
            {
                noticeClientLabel.Text = "";
            }
            else
            {
                idnTextBox.Text = "";
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                passTextBox.Text = "";
                creditcardTextBox.Text = "";
                noticeClientLabel.Text = "No exist the id of client";
            }
        }

        protected void addReserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientTextBox.Text != "" && arrivalDateTextBox.Text != "" && finishDateTextBox.Text != "" && typeRoomTextBox.Text != "")
                {
                    ws.addReserve(Int32.Parse(id), Int32.Parse(clientTextBox.Text.ToString()), arrivalDateTextBox.Text.ToString(), finishDateTextBox.Text.ToString(), typeRoomTextBox.Text.ToString());

                    idReserveTextBox.Text = "";
                    clientTextBox.Text = "";
                    arrivalDateTextBox.Text = "";
                    finishDateTextBox.Text = "";
                    typeRoomTextBox.Text = "";
                    noticeReserveLabel.Text = "";

                    updateListReservas();
                }
                else
                {
                    noticeReserveLabel.Text = "Some field is missing";
                }
            }
            catch (Exception ex)
            {
                noticeReserveLabel.Text = "the reservation could not be added";
            }
            
        }

        protected void delReserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (idReserveTextBox.Text != "")
                {
                    ws.delReserve(Int32.Parse(idReserveTextBox.Text), Int32.Parse(id));
                    
                    idReserveTextBox.Text = "";
                    clientTextBox.Text = "";
                    arrivalDateTextBox.Text = "";
                    finishDateTextBox.Text = "";
                    typeRoomTextBox.Text = "";
                    noticeReserveLabel.Text = "";

                    updateListReservas();

                }
                else
                {
                    noticeReserveLabel.Text = "The id field is empty";
                }
            }
            catch (Exception)
            {
                noticeReserveLabel.Text = "Unable to delete reservation";
            }
        }

        protected void modReserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (idReserveTextBox.Text != "" && clientTextBox.Text != "" && arrivalDateTextBox.Text != "" && finishDateTextBox.Text != "" && typeRoomTextBox.Text != "")
                {
                    ws.updateReserve(Int32.Parse(idReserveTextBox.Text), Int32.Parse(id), Int32.Parse(clientTextBox.Text), arrivalDateTextBox.Text, finishDateTextBox.Text, typeRoomTextBox.Text);

                    updateListReservas();
                    idReserveTextBox.Text = "";
                    clientTextBox.Text = "";
                    arrivalDateTextBox.Text = "";
                    finishDateTextBox.Text = "";
                    typeRoomTextBox.Text = "";
                    noticeReserveLabel.Text = "";
                }
                else
                {
                    noticeReserveLabel.Text = "Some field is missing";
                }
            }
            catch (Exception)
            {
                noticeReserveLabel.Text = "the reservation has not been modified correctly";
            }
        }

        protected void infoRecepcionist()
        {

            dt = ws.DataRecepcionist(Int32.Parse(id));

            foreach (DataRow dr in dt.Rows)
            {
                id = dr["id"].ToString();
                idnLabel.Text = dr["idn"].ToString();
                nameRecepcionist = dr["name"].ToString();
                nameLabel.Text = nameRecepcionist + " " + dr["surname"].ToString();
            }

            updateListReservas();

            updateListClients();
        }

        protected void updateListReservas()
        {
            ListBox1.Items.Clear();
            dt = ws.DataReserve(Int32.Parse(id), 1);

            foreach (DataRow dr in dt.Rows)
            {

                dt = ws.DataClient(Int32.Parse(dr["idClient"].ToString()));

                foreach (DataRow dr1 in dt.Rows)
                {
                    Reserva reserva = new Reserva(dr["id"].ToString(), nameRecepcionist, dr1["name"].ToString(), dr["arrivalDate"].ToString(), dr["finishDate"].ToString(), dr["typeRoom"].ToString());
                    ListBox1.Items.Add(reserva.ToString());
                    reservas.Add(reserva);
                }
            }
        }

        protected void addClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (idnTextBox.Text != "" && nameTextBox.Text != "" && surnameTextBox.Text != "" && passTextBox.Text != "" && creditcardTextBox.Text != "")
                {

                    ws.addClient(Int32.Parse(idnTextBox.Text), nameTextBox.Text, surnameTextBox.Text, Int32.Parse(passTextBox.Text), Int32.Parse(creditcardTextBox.Text));

                    idnTextBox.Text = "";
                    nameTextBox.Text = "";
                    surnameTextBox.Text = "";
                    passTextBox.Text = "";
                    creditcardTextBox.Text = "";
                    idClientTextBox.Text = "";

                    updateListClients();
                }
                else
                {
                    noticeClientLabel.Text = "Some field is missing";
                }
            }
            catch (Exception ex)
            {
                noticeClientLabel.Text = "the client could not be added";
            }
        }

        protected void modClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (idnTextBox.Text != "" && idClientTextBox.Text != "" && nameTextBox.Text != "" && surnameTextBox.Text != "" && passTextBox.Text != "" && creditcardTextBox.Text != "")
                {
                    ws.updateClient(Int32.Parse(idClientTextBox.Text), Int32.Parse(idnTextBox.Text), nameTextBox.Text, surnameTextBox.Text, Int32.Parse(passTextBox.Text), Int32.Parse(creditcardTextBox.Text));

                    idnTextBox.Text = "";
                    nameTextBox.Text = "";
                    surnameTextBox.Text = "";
                    passTextBox.Text = "";
                    creditcardTextBox.Text = "";
                    idClientTextBox.Text = "";

                    updateListClients();
                }
                else
                {
                    noticeClientLabel.Text = "Some field is missing";
                }
            }
            catch (Exception)
            {
                noticeClientLabel.Text = "the client has not been modified correctly";
            }
        }

        protected void delClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (idClientTextBox.Text != "")
                {
                    ws.delClient(Int32.Parse(idClientTextBox.Text));
                    
                    idnTextBox.Text = "";
                    nameTextBox.Text = "";
                    surnameTextBox.Text = "";
                    passTextBox.Text = "";
                    creditcardTextBox.Text = "";
                    idClientTextBox.Text = "";

                    updateListClients();

                }
                else
                {
                    noticeClientLabel.Text = "The id field is empty";
                }
            }
            catch (Exception)
            {
                noticeClientLabel.Text = "Unable to delete client";
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["authentication"] = false;
            Session["id"] = null;
            Response.Redirect("../Login.aspx");
            
        }

        protected void jsonButton_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(reservas);

            try
            {
                var dataFile = Server.MapPath("Reserves.json");
                File.WriteAllText(@dataFile, json);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected void updateListClients()
        {
            ListBox2.Items.Clear();

            dt = ws.allClients(0);
            string client;
            foreach (DataRow dr in dt.Rows)
            {

                client = "ID: " + dr["id"].ToString() + " --> \t";
                client += dr["idn"].ToString() + " \t";
                client += dr["name"].ToString() + " \t";
                client += dr["surname"].ToString() + " \t";
                client += dr["pass"].ToString() + " \t";
                client += dr["creditcard"].ToString();
                ListBox2.Items.Add(client);
            }
        }
    }
}
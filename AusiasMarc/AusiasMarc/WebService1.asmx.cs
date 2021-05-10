using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SQLite;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace AusiasMarc
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public string DBpath = HttpRuntime.AppDomainAppPath + "database.db";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataTable LoginRecepcionist(int idn)
        {
            DataTable dt = new DataTable();
            
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Recepcionist WHERE idn='" + idn + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable LoginClient(int idn)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Client WHERE idn='" + idn + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable allClients(int id)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm;

                if (id == 0)
                {
                    comm = new SQLiteCommand("SELECT * FROM Client", conn);
                }
                else
                {
                    comm = new SQLiteCommand("SELECT * FROM Client WHERE id='" + id + "'", conn);
                }
                 
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable DataRecepcionist(int id)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Recepcionist WHERE id='" + id + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable DataClient(int id)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Client WHERE id='" + id + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable DataReserve(int id, int rol)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm;
                if (rol == 0)
                {
                    comm = new SQLiteCommand("SELECT * FROM Reserve WHERE idClient='" + id + "'", conn);
                }
                else
                {
                    comm = new SQLiteCommand("SELECT * FROM Reserve WHERE idRecepcionist='" + id + "'", conn);
                }
                
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public DataTable DataReserveId(int id, int idRecepcionist)
        {
            DataTable dt = new DataTable();

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM Reserve WHERE id='" + id + "' AND idRecepcionist='" + idRecepcionist + "'", conn);


                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            return dt;
        }

        [WebMethod]
        public void addReserve(int idRecepcionist, int idClient, string arrivalDate, string finishDate, string typeRoom)
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("INSERT INTO Reserve (idRecepcionist, idClient, arrivalDate, finishDate, typeRoom) VALUES ('" + idRecepcionist + "', '" + idClient + "', '" + arrivalDate + "', '" + finishDate + "', '" + typeRoom + "')", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                reader.Close();
            }
        }

        [WebMethod]
        public void delReserve(int id)
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("DELETE FROM Reserve WHERE id='" + id + "'", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                reader.Close();
            }
        }

        [WebMethod]
        public void updateReserve(int id, int idRecepcionist, int idClient, string arrivalDate, string finishDate, string typeRoom)
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;");

            conn.Open();
            using (conn)
            {
                SQLiteCommand comm = new SQLiteCommand("UPDATE Reserve SET idRecepcionist ='" + idRecepcionist + "', idClient = '" + idClient + "', arrivalDate = '" + arrivalDate + "', finishDate = '" + finishDate + "', typeRoom = '" + typeRoom + "' WHERE id = " + id, conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                reader.Close();
            }
        }
    }
}

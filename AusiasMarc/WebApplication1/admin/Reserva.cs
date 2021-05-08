using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.admin
{
    public class Reserva
    {

        public string NameRecepcionist { get; set; }
        public string NameClient { get; set; }
        public string arrivalDate { get; set; }
        public string finishDate { get; set; }
        public string typeRoom { get; set; }

        public int Valor { get; set; } // Valor del disco

        public Reserva(string NameRecepcionist, string NameClient, string arrivalDate, string finishDate, string typeRoom)
        {
            this.NameRecepcionist = NameRecepcionist;
            this.NameClient = NameClient;
            this.arrivalDate = arrivalDate;
            this.finishDate = finishDate;
            this.typeRoom = typeRoom;
        }

        public string ToString()
        {
            return NameRecepcionist + " \t" + NameClient + " \t" + arrivalDate + " \t" + finishDate + " \t" + typeRoom;
        }




    }
}
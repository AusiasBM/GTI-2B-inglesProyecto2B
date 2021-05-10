using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.admin
{
    public class Reserva
    {
        public string idReserva { get; set; }
        public string NameRecepcionist { get; set; }
        public string NameClient { get; set; }
        public string arrivalDate { get; set; }
        public string finishDate { get; set; }
        public string typeRoom { get; set; }

        public Reserva(string idReserva, string NameRecepcionist, string NameClient, string arrivalDate, string finishDate, string typeRoom)
        {
            this.idReserva = idReserva;
            this.NameRecepcionist = NameRecepcionist;
            this.NameClient = NameClient;
            this.arrivalDate = arrivalDate;
            this.finishDate = finishDate;
            this.typeRoom = typeRoom;
        }

        override
        public string ToString()
        {
            return "ID: " + idReserva + "-->" + " \t" + NameRecepcionist + " \t" + NameClient + " \t" + arrivalDate + " \t" + finishDate + " \t" + typeRoom;
        }




    }
}
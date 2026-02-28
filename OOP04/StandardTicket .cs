using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class StandardTicket:Ticket
    {

        public string SeatNumber { get; set; }
        public StandardTicket(string name, decimal price, string seat) : base(name, price)
        {
            SeatNumber = seat;
        }


        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | Seat: {SeatNumber}");
        }
    }
}

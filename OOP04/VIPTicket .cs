using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class VIPTicket : Ticket
    {

        public string LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50;
        public VIPTicket(string name, decimal price, bool loungeAccess, decimal serviceFee) : base(name, price)
        {
            LoungeAccess = loungeAccess ? "yes" : "No";
            ServiceFee = serviceFee;
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | LoungeAccess : {LoungeAccess} | ServiceFee : {ServiceFee} EGP");
        }
    }
}

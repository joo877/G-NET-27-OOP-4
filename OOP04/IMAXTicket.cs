using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class IMAXTicket:Ticket
    {

        public string Is3D { get; set; }

        public IMAXTicket(string name, decimal price, bool is3D) : base(name, price += is3D ? 30 : 0)
        {
            Is3D = is3D ? "Yes" : "No";

        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | MovieName : {MovieName} | price : {Price} EGP | PriceAfterTax : {PriceAfterTax} EGP | Is3D : {Is3D}");
        }



    }
}

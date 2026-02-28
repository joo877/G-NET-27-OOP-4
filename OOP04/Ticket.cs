using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class Ticket
    {
        private decimal _price;
        public string MovieName { get; set; }

        public decimal PriceAfterTax => _price + _price * .14m;

        private static int ticketCounter = 0;

        public int TicketId { get; }
        public decimal Price
        {
            get { return _price; }
            set
            {

                if (value > 0)
                    _price = value;
            }
        }

        public Ticket(string name, decimal price)
        {
            MovieName = name;
            Price = price;
            ticketCounter++;
            TicketId = ticketCounter;


        }

        

        public static int GetTotalTickets()
        {
            return ticketCounter;
        }

        public void Setprice(decimal price) 
        {
            Price = price;
            Console.WriteLine($"{Price}");
        }

        public void Setprice(decimal price,decimal multiplier)
        {
        Price = price * multiplier;
            Console.Write($"{price} x {multiplier}= {Price}");
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($" TicketId : {TicketId} | MovieName : {MovieName} | price : {Price} | PriceAfterTax : {PriceAfterTax}");
        }
    }
}

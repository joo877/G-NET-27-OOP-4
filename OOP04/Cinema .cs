using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class Cinema
    {
        private Projector projector = new Projector(); 

        private Ticket[] _ticket=new Ticket[20];
      
        public void AddTicket(Ticket T) 
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] == null)
                {
                    _ticket[i] = T;
                    return;
                }
               
               
            }


        }
        public void PrintAllTickets() 
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] != null)
                 _ticket[i].PrintTicket();
                      

            }

        }


        public static void ProcessTicket(Ticket T)=> T.PrintTicket();



        public void OpenCinema() => projector.OpenProjector();
        public void CloseCinema() => projector.CloseProjector();

      

    }
}

using System;

namespace Caso12021
{
    class Program
    {
        static void Main(string[] args)
        {

            TVShow show = new TVShow("Zapeando");
            Broadcasting broad = new Broadcasting(new DateTime(2021, 10, 22), show);
            show.FirstBroadCasting = broad;
            show.Broadcastings.Add(broad);

            Conductor cond = new Conductor("Dani Mateo", "963877007", broad, 15000);
            broad.Participants.Add(cond);

            Contract cont = new Contract(10000, show, cond);
            cond.Contracts.Add(cont);
            show.Contracts.Add(cont);

            Console.WriteLine("Done!");
        }
    }
}

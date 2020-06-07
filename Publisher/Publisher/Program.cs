using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p1 = new Publisher();
            SubscriberA sA = new SubscriberA();
            SubscriberB sB = new SubscriberB();
            p1.Eveniment += new iteratie(sA.iteratie);
            p1.Eveniment += new iteratie(sB.iteratie);
            p1.DeclansareEveniment();
            Console.ReadKey();

        }
    }
}

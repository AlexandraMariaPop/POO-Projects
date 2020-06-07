using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
    public delegate void iteratie(int parameter);
    class Publisher
    {
        public event iteratie Eveniment;
        public void DeclansareEveniment()
        {
            for (int i = 0; i < 15; i++)
            {
                if (this.Eveniment != null)
                    this.Eveniment(i);
                else
                    Console.WriteLine("Nu exista niciun eveniment");

            }

        }
    }
}

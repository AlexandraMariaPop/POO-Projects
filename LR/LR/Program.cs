using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            LR a = new LR("input.txt");
            a.ReadData();
            a.ProcessData();
            a.ShowResults();
        }
    }
}

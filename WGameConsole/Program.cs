using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WGameExample.Model;

namespace WGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                RandomPlayer randomPlayer = new RandomPlayer();

                randomPlayer.displayInformationInConsole();
            }

            Console.ReadKey();
        }
    }
}

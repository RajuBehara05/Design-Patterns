using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating new atm machine
            ATM atm = new ATM();

            //withdrawing amount
            Console.WriteLine("\n Requested Amount 4500");
            atm.withdraw(4500);
            Console.WriteLine("\n Requested Amount 2000");
            atm.withdraw(2000);
            Console.WriteLine("\n Requested Amount 500");
            atm.withdraw(500);

            //holding console window
            Console.Read();
        }
    }
}

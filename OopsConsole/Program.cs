﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            SavingAccount objS = new SavingAccount();
            objS.AcHolderDetails();
            Console.WriteLine();

            objS.Withdraw();
            Console.WriteLine();

            objS.InterestRate();
            Console.WriteLine();


            CurrentAccount objC = new CurrentAccount();
            objC.AcHolderDetails();
            Console.WriteLine();

            objC.Withdraw();
            Console.WriteLine();

            objC.InterestRate();
            Console.WriteLine();

        }
    }
}
 


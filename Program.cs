using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicon_ATMCashWithdrawal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region dowork
            test:
            try
            {
                Console.WriteLine("Please enter the amount you wish to withdraw.");
            int amount = Convert.ToInt32(Console.ReadLine());

            int fivehundredNotes = 0, hundredNotes = 0, fiftyNotes = 0, tenNotes=0, fiveNotes=0;
            //int amount = 0;
           

                if (amount % 5 != 0)
                {
                    Console.WriteLine("Invalid Amount!");
                    Console.WriteLine();
                    goto test;
                }
                else
                {
                    //check for 500 notes
                    if (amount >= 500)
                    {
                        fivehundredNotes = amount / 500;
                        amount = amount % 500;
                    }
                    //check for 100 notes
                    if (amount >= 100 && amount != 0)
                    {
                        hundredNotes = amount / 100;
                        amount = amount % 100;
                    }
                    //check for 50 notes
                    if (amount >= 50 && amount != 0)
                    {
                        fiftyNotes = amount / 50;
                        amount = amount % 50;
                    }
                    //check for 10 notes
                    if (amount >= 10 && amount != 0)
                    {
                        tenNotes = amount / 10;
                        amount = amount % 10;
                    }
                    //check for 5 notes
                    if (amount >= 5 && amount != 0)
                    {
                        fiveNotes = amount / 5;
                        amount = amount % 5;
                    }

                    if (fivehundredNotes > 0)
                        Console.WriteLine("500 * " + fivehundredNotes);
                    if (hundredNotes > 0)
                        Console.WriteLine("100 * " + hundredNotes);
                    if (fiftyNotes > 0)
                        Console.WriteLine("50 * " + fiftyNotes);
                    if (tenNotes > 0)
                        Console.WriteLine("10 * " + tenNotes);
                    if (fiveNotes > 0)
                        Console.WriteLine("5 * " + fiveNotes);
                    
                }
            }
            catch(Exception ex)

            {
                Console.WriteLine("Invalid entry.");
                Console.WriteLine();
                goto test;
            }
            Console.ReadLine();
            #endregion
        }
    }
}

using System;

namespace BankTutorial
{
    class Program
    {
        public class Account
        {
            public double balance;

            public Account()
            {
                balance = 500.00;
            }

            public double Deposite()
            {
                double NewBalance;
                double Deposite;
                Console.WriteLine("Vänligen skriv belopp att sätta in.");
                Deposite = double.Parse(Console.ReadLine());
                NewBalance = balance + Deposite;
                return NewBalance;
            }  

            public double Withdrawl()
            {
                double NewBalance;
                double Withdrawl;
                Console.WriteLine("Vänligen skriv belopp att ta ut.");
                Withdrawl = double.Parse(Console.ReadLine());
                NewBalance = balance - Withdrawl;
                return NewBalance;
            }
        }

        static void Main(string[] args)
        {
            double NewBalance;
            string balance;
            Account bank = new Account();
            Console.WriteLine("Belopp på kontot: 500.00");
            Console.WriteLine("Tryck 'i' för insättning eller 'u' för uttag.");

            balance = Console.ReadLine();

            if(balance == "i")
            {
                NewBalance = bank.Deposite();
                Console.WriteLine("Belopp på konto efter insättning: {0} ", NewBalance);
            }
            if(balance == "u")
            {
                NewBalance = bank.Withdrawl();
                Console.WriteLine("Belopp på konto efter uttag: {0} ", NewBalance);
            }

            Console.ReadLine();
        }
    }
}

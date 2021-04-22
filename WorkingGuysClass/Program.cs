using System;

namespace WorkingGuysClass
{
    class Guy
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " I don't have enough money to give " + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't an amount i'll take");
            }
            else
            {
                Cash += amount;
            }
        }
        static void Main(string[] args)
        {
            Guy john = new Guy() { Cash = 50, Name = "John" };

            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                bob.WriteMyInfo();
                john.WriteMyInfo();

                Console.WriteLine("Enter amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "john")
                    {
                        int cashGiven = john.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        john.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'john' or 'bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank to exit).");
                }
            }
        }
    }
}

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
        static void Main(string[] args)
        {
            Guy John = new Guy() { Cash = 50, Name = "John" };

            Console.WriteLine(John.GiveCash(50));
        }
    }
}

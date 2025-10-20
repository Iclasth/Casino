using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGuysTrading
{
    public class Guy
    {
        public string Name { get; set; } = string.Empty;
        public int Cash { get; set; } 

        public Guy(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        /// <summary>
        /// A simple method to write out the guy's info (his name and cash).
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"Hi! i'm {Name} and i have {Cash} bucks (dolar).");
        }

        /// <summary>
        /// Withdraws a specified amount of cash from the available balance.
        /// </summary>
        /// <remarks>If the requested amount is less than or equal to 0, or if it exceeds the available
        /// cash balance, the method will return 0 and no cash will be withdrawn.</remarks>
        /// <param name="amount">The amount of cash to withdraw. Must be greater than 0 and less than or equal to the available cash balance.</param>
        /// <returns>The amount of cash successfully withdrawn. Returns 0 if the requested amount is invalid or exceeds the
        /// available balance.</returns>
        public double GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't an amount I'll take.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enough cash to give you {amount} bucks.");
                return 0;
            }
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Adds the specified amount of cash to the current balance.
        /// </summary>
        /// <remarks>If the specified <paramref name="amount"/> is less than or equal to 0, the method
        /// will not modify the balance and will return 0. Otherwise, the specified amount is added to the current
        /// balance.</remarks>
        /// <param name="amount">The amount of cash to add. Must be greater than 0.</param>
        /// <returns>The amount of cash successfully added. Returns 0 if the specified amount is less than or equal to 0.</returns>
        public void ReciveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says: {amount} isn't an amount that i can take.");
                
            }
            Cash += amount;
            
        }
    }
}

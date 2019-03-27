using StrategyPattern.Class;
using StrategyPattern.Enum;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passenger Membership Discount %");
            Console.WriteLine($"Silver   membership discount  {ImplementationContext.GetDiscount(eMember.Silver)}%");
            Console.WriteLine($"Gold     membership discount  {ImplementationContext.GetDiscount(eMember.Gold)}%");
            Console.WriteLine($"Platinum membership discount  {ImplementationContext.GetDiscount(eMember.Platinum)}%");
        }
    }
}

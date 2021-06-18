using BusinessRuleEngine.Interfaces;
using System;
using System.Threading;

namespace BusinessRuleEngine.Rules
{
    public class PhysicalProduct : IRule
    {
        public void ProcessRule()
        {
            Console.WriteLine("Generating packing slip for shipping.");
            Thread.Sleep(2000);
            Console.WriteLine("Generated packing slip for shipping.");
        }
    }
}

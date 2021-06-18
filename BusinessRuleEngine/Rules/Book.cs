using BusinessRuleEngine.Interfaces;
using System;
using System.Threading;

namespace BusinessRuleEngine.Rules
{
    public class Book : IRule
    {
        public void ProcessRule()
        {
            Console.WriteLine("Generating duplicate packing slip generated for royalty department.");
            Thread.Sleep(2000);
            Console.WriteLine("Generated duplicate packing slip generated for royalty department.");
        }
    }
}

using BusinessRuleEngine.Interfaces;
using System;
using System.Threading;

namespace BusinessRuleEngine.Rules
{
    public class MemberShip : IRule
    {
        public void ProcessRule()
        {
            Console.WriteLine("Activating membership.");
            Thread.Sleep(2000);
            Console.WriteLine("Activated membership.");
        }
    }
}

using BusinessRuleEngine.Interfaces;
using System;
using System.Threading;

namespace BusinessRuleEngine.Rules
{
    public class UpgradeMemberShip : IRule
    {
        public void ProcessRule()
        {
            Console.WriteLine("Upgrading membership to premium.");
            Thread.Sleep(1000);
            Console.WriteLine("Upgraded membership to premium.");
        }
    }
}

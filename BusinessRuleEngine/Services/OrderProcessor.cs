using BusinessRuleEngine.Interfaces;
using BusinessRuleEngine.Rules;
using System;
using System.Collections.Generic;

namespace BusinessRuleEngine.Services
{
    public class OrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(List<IRule> listOfRules)
        {
            foreach (var rule in listOfRules)
            {
                var ruleType = rule.GetType();

                Console.WriteLine($":::Processing rule of type {ruleType.Name}:::");
                rule.ProcessRule();

                if (ruleType == typeof(Book) || ruleType == typeof(PhysicalProduct))
                    GenerateCommission();

                else if (ruleType == typeof(MemberShip) || ruleType == typeof(UpgradeMemberShip))
                    SendMail(ruleType);

                Console.WriteLine("---------------------------------");
            }
        }

        public void GenerateCommission() => Console.WriteLine("Generating commission for the agent.");

        public void SendMail(Type type)
        {
            if (type.Name.Equals("MemberShip"))
                Console.WriteLine("Sent mail of membership activation.");

            else
                Console.WriteLine("Sent mail of membership upgrade.");

        }
    }
}

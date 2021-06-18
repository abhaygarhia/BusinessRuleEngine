using BusinessRuleEngine.Interfaces;
using BusinessRuleEngine.Rules;
using BusinessRuleEngine.Services;
using System;
using System.Collections.Generic;

namespace BusinessRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfRules = new List<IRule> { new Book(), new MemberShip(), new UpgradeMemberShip(), new PhysicalProduct(), new Video("Learning to Ski"), new Video("Binaural beats") };
            var orderProcessor = new OrderProcessor();

            orderProcessor.ProcessOrder(listOfRules);
            Console.ReadLine();
        }
    }
}

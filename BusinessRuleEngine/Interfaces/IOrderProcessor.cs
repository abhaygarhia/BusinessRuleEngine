using System;
using System.Collections.Generic;

namespace BusinessRuleEngine.Interfaces
{
    public interface IOrderProcessor
    {
        void ProcessOrder(List<IRule> listOfRules);

        void SendMail(Type type);

        void GenerateCommission();
    }
}

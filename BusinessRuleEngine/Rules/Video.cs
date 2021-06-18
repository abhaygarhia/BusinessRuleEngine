using BusinessRuleEngine.Interfaces;
using System;
using System.Threading;

namespace BusinessRuleEngine.Rules
{
    public class Video : IRule
    {
        private readonly string _videoName;
        
        public Video(string videoname)
        {
            _videoName = videoname;
        }

        public void ProcessRule()
        {
            Console.WriteLine("Adding video.");
            Thread.Sleep(1000);
            Console.WriteLine("Added video.");

            if (_videoName.Equals("Learning to Ski"))
                Console.WriteLine("Adding a free 'First Aid' video to the packing slip (the result of a court decision in 1997).");
        }
    }
}

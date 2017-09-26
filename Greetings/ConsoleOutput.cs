using System;
using GreetingsFramework;

namespace Greetings
{
    class ConsoleOutput : IGreetingOutput
    {
        public void SetGreeting(string lang)
        {
            var greeting = Greeting.GetGreeting(lang);
            Console.WriteLine(greeting);
            Console.ReadLine();
        }
    }
}

using System;
using GreetingsFramework;

namespace Greetings
{
    class DatabaseOutput : IGreetingOutput
    {
        public void SetGreeting(string lang)
        {
            Console.WriteLine("Here, I'm pretending that I'm writing to a database. Bear with me...");
            var greeting = Greeting.GetGreeting(lang);
            Console.WriteLine(greeting);
            Console.ReadLine();
        }
    }
}

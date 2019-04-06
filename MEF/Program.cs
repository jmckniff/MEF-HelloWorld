using System;

namespace MEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetingService = new GreetingService();

            greetingService.DisplayGreeting();

            Console.ReadLine();
        }
    }
}

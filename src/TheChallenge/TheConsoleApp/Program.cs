using System;
using System.Linq;

namespace TheConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a set of waiting time in seconds separated by space (' '):");
            var numbersTextInput = Console.ReadLine();
            var numbers = numbersTextInput.Split(' ').Select(it => Convert.ToInt32(it)).ToArray();
            Console.WriteLine("This is what you've entered:");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var waitingTime = new WaitingTime(numbers);

            Console.WriteLine("Enter your appointment number to looking for the wainting time:");
            var appNumberTextInput = Console.ReadLine();
            var appNumber = Convert.ToInt32(appNumberTextInput);
            var appWaitingTime = waitingTime.Find(appNumber);
            Console.WriteLine(appWaitingTime);
        }
    }
}

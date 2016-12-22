using System;
using EasyCQS.Core;

namespace EasyCQS.Example.Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var container = new SimpleContainer();
			var bus = new Bus(container);
			var command = new ExampleCommand("HELLO WORLD!");

			bus.Publish(command);

	        Console.ReadKey();
        }
    }
}

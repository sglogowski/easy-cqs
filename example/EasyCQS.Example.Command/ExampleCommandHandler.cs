using System;
using EasyCQS.Core;

namespace EasyCQS.Example.Command
{
	public class ExampleCommand : ICommand
	{
		public ExampleCommand(string message)
		{
			Message = message;
		}

		public string Message { get; }
	}

	public class ExampleCommandHandler : ICommandHandler<ExampleCommand>
	{
		public void Execute(ExampleCommand command)
		{
			Console.WriteLine(command.Message);
		}
	}
}
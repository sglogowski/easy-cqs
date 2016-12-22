using System;
using EasyCQS.Core;

namespace EasyCQS.Example.Command
{
	public class SimpleContainer : IContainer
	{
		public ICommandHandler<TCommand> Resolve<TCommand>() where TCommand : ICommand
		{
			if (typeof(TCommand) == typeof(ExampleCommand))
			{
				return (ICommandHandler<TCommand>) new ExampleCommandHandler();
			}

			throw new Exception("MISSING REGISTRATION FOR GIVEN TYPE");
		}
	}
}
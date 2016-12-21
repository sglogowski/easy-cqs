namespace EasyCQS.Core
{
	public interface ICommand { }

	public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}
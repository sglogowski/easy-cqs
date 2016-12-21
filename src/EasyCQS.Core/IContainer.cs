namespace EasyCQS.Core
{
    public interface IContainer
    {
        ICommandHandler<TCommand> Resolve<TCommand>() where TCommand : ICommand;
    }
}
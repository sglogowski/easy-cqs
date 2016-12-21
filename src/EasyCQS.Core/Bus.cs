namespace EasyCQS.Core
{
    public interface IBus
    {
        void Publish<TCommand>(TCommand command) where TCommand : ICommand;
    }

    public class Bus : IBus
    {
        private readonly IContainer _container;

        public Bus(IContainer container)
        {
            _container = container;
        }

        public virtual void Publish<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = _container.Resolve<TCommand>();
            handler.Execute(command);
        }
    }
}
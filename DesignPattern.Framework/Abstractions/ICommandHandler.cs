namespace DesignPattern.Framework.Abstractions
{
    public interface ICommandHandler<ICommand>
    {
        void Handle(ICommand command);
    }
}

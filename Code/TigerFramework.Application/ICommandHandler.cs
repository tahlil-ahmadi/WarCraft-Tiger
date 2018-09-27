namespace TigerFramework.Application
{
    public interface ICommandHandler<T>
    {
        void Handle(T command);
    }
}
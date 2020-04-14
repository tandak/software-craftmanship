namespace software_craftsmanship.Lib.ChainOfResponsiblity
{
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private IHandler<T> Next;

        public virtual void Handle(T request) //using virtual to change the behavouir in other classes
        {
            Next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }

    public interface IHandler<T> where T: class
    {
        IHandler<T> SetNext(IHandler<T> next);

        void Handle(T request);
    }
}

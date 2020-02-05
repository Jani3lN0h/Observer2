namespace PracticaObserver2.Service.Interface
{
    public interface IObservable
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
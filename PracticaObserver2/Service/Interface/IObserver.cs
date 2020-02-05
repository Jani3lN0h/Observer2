using static PracticaObserver2.Domain.ETypesObserver;

namespace PracticaObserver2.Service.Interface
{
    public interface IObserver
    {
        TypesObserver typeObserver { get; }

        void Notify(IObservable observable);
    }
}
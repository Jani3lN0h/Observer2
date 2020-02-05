using PracticaObserver2.Service.Interface;
using System;
using static PracticaObserver2.Domain.ETypesObserver;

namespace PracticaObserver2.Service
{
    public class Compiler : IObserver
    {
        public TypesObserver typeObserver => TypesObserver.Compiler;

        public void Notify(IObservable observable)
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}

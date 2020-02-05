using PracticaObserver2.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticaObserver2.Domain.ETypesObserver;

namespace PracticaObserver2.Service
{
    public class Tester : IObserver
    {
        public TypesObserver typeObserver => TypesObserver.Tester;

        public void Notify(IObservable observable)
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}

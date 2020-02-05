using PracticaObserver2.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticaObserver2.Domain.ETypesObserver;

namespace PracticaObserver2.Service
{
    public class Installer : IObserver
    {
        public TypesObserver typeObserver => TypesObserver.Installer;

        public void Notify(IObservable observable)
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}

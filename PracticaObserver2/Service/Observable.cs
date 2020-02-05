using PracticaObserver2.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaObserver2.Service
{
    public class Observable : IObservable
    {
        private readonly List<IObserver> _lstObservers = new List<IObserver>();

        public void Main()
        {
            bool lNotify = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elige la acción que desea ejecutar: ");
            Console.WriteLine("1 - Subir el código");
            Console.WriteLine("2 - Agregar Notificador");
            Console.WriteLine("3 - Agregar Compilador");
            Console.WriteLine("4 - Agregar Ejecutor de Pruebas Unitarias");
            Console.WriteLine("5 - Agregar Instalador");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ResetColor();
            int iObserver = Convert.ToInt32(Console.ReadLine());
            IObserver observer = new Repository();
            switch (iObserver)
            {
                case 1:
                    observer = new Repository();
                    lNotify = true;
                    break;
                case 2:
                    observer = new Notifier();
                    break;
                case 3:
                    observer = new Compiler();
                    break;
                case 4:
                    observer = new Tester();
                    break;
                case 5:
                    observer = new Installer();
                    break;
                default:
                    Console.WriteLine("Ha ingresado un valor incorrecto.\r\n Favor de intentar nuevamente.");
                    Main();
                    break;
            }
            Attach(observer);
            if (lNotify)
            {
                MainBusinessLogic();
                Console.WriteLine("\r\nPresione una tecla para salir.");
                Console.ReadKey();
            }
            else
            {
                Main();
            }

        }

        public void Attach(IObserver observer)
        {
            if (_lstObservers.Any(x => x.typeObserver == observer.typeObserver))
            {
                Console.WriteLine("Ya se ha agregado el observador.");
            }
            else
            {
                this._lstObservers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            if (!_lstObservers.Exists(x => x.typeObserver == observer.typeObserver))
            {
                Console.WriteLine("No existe el observador.");
            }
            else
            {
                this._lstObservers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in this._lstObservers)
            {
                observer.Notify(this);
            }
        }

        public void MainBusinessLogic()
        {
            this.Notify();
        }
    }
}
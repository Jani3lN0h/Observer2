using PracticaObserver2.Service;
using PracticaObserver2.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObserver2
{
    class Program
    {
        static void Main(string[] args)
        {            
            var observable = new Observable();
            observable.Main();
        }
    }
}

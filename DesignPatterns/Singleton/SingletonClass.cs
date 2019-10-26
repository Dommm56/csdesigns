using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class SingletonClass //Thread-safe
    {
        private static SingletonClass _instance = null;

        private static readonly object _lock = new object();

        SingletonClass() { }

        public static SingletonClass SingleInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                        Console.WriteLine("Une instance est cree");
                    }
                    else
                    {
                        Console.WriteLine("Une instance existe deja");
                    }
                    return _instance;
                }
            }
        }
    }
}

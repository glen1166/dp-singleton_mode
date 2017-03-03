using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMode
{
    public class Emperor
    {
        private static readonly Emperor _instance = new Emperor();

        public static object _lock = new object();

        private Emperor() { }

        public static Emperor Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Say()
        {
            Console.WriteLine("I'm QianLong.");
        }
    }
}

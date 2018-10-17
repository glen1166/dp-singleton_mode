using System;

namespace SingletonMode
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                Emperor.Instance.Say();
            }
        }
    }
}

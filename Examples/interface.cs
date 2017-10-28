using System;

namespace OperatorOvlApplication
{
    public interface a
    {
        void show();
    }
    class b : a
    {
        public void show()
        {
            System.Console.WriteLine("hiiii");
        }
    }

    class Tester
    {

        static void Main(string[] args)
        {
            b xx = new b();
            xx.show();
            Console.ReadKey();
        }
    }
}
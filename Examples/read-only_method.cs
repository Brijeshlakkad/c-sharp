using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

class A
{
    private int _v=10;
    public int xyz   //read-only method
    {
        get{
            return _v;
        }
    }
}
namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.xyz);
            
        }
    }
}
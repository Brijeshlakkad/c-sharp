using System;

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
    public readonly string Url;

    public string Topic  {
      get {
         return topic;
      }

set {
         topic = value;
      }
   }
   
   public HelpAttribute(string url)  {
      this.Url = url;
   }
private string topic;
}

[HelpAttribute("Information on the class MyClass")]
class MyClass
{

}

namespace AttributeAppl
{

    class Program
    {

        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }
}
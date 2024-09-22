using System;

namespace NamespaceA
{
    public class ClassA
    {
        public string FieldA = "This is FieldA in ClassA";

        public void MethodA()
        {
            Console.WriteLine("MethodA from ClassA in NamespaceA.");
        }
    }
}
namespace NamespaceB
{
    public class ClassB
    {
        public string FieldB = "This is FieldB in ClassB";

        public void MethodB()
        {
            Console.WriteLine("MethodB from ClassB in NamespaceB.");
        }
    }
}

namespace MainNamespace
{
    using NamespaceA;
    using NamespaceB;

    class Program
    {
      /*  static void Main(string[] args)
        {
            ClassA objectA = new ClassA();
            Console.WriteLine(objectA.FieldA);
            objectA.MethodA();

            ClassB objectB = new ClassB();
            Console.WriteLine(objectB.FieldB);
            objectB.MethodB();
        } */
    }
}

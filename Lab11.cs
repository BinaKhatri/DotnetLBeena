using System;

namespace DotnetLBeena
{
    internal class Lab11
    {
        public class Container<T>
        {
            private T _data;

         
            public void SetValue(T value)
            {
                _data = value;
            }
            public T GetValue()
            {
                return _data;
            }
        }
        public class Utilities
        {
             public void DisplayInfo<T>(T data)
            {
                Console.WriteLine($"Type: {typeof(T)}, Value: {data}");
            }
        }

        class Q11
        {
          /*  static void Main(string[] args)
            {
            
                Container<int> intContainer = new Container<int>();
                intContainer.SetValue(123);
                Console.WriteLine("Integer Container Value: " + intContainer.GetValue());

              
                Container<string> stringContainer = new Container<string>();
                stringContainer.SetValue("Hello,Beena !");
                Console.WriteLine("String Container Value: " + stringContainer.GetValue());

                
                Utilities utilities = new Utilities();
                utilities.DisplayInfo(984); 
                utilities.DisplayInfo("Generic Method Test"); 

             
                Console.ReadLine();
            } */
        }
    }
}


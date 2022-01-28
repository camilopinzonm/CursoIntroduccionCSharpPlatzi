using System;

namespace CursoIntroduccionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Platzi!");

            int height = 175;
            int age = 38 ;
            string name = "Camilo Pinzon";
            string information = "the requested info is: \n User name " + name + "\n user age "
                + age + " \n user height " + height;
            Console.WriteLine(information);
        }
    }
}

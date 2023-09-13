using System;

namespace MT130923
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido usuario, digita el numero");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine ($"\nEl valor resultante del numero que diste es : {7 * (num / 2 )}");
            }

            else if (num % 2 == 1) 
            {
                Console.WriteLine($"\nEl valor resultante del numero que diste es : { -1 * (num - 1) }");
            }


        }
    }
}
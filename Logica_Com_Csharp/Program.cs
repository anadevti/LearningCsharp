using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 126; // O Byte nao aceita numero negativo
            int n2 = 1000;
            int n3 = 2147483647; // O int é o tipo de variável mais usado
            long n4 = 2147483648L; // O long é um inteiro de 64 bits
            
            Console.WriteLine(x); // equivale ao Print no Python
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
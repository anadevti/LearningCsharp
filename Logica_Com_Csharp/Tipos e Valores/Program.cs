using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F'; // O char é um caractere simples
            sbyte x = 100;
            byte n1 = 126; // O Byte nao aceita numero negativo
            int n2 = 1000;
            int n3 = 2147483647; // O int é o tipo de variável mais usado
            long n4 = 2147483648L; // O long é um inteiro de 64 bits
            float n5 = 4.5f; // O float é um número de ponto flutuante
            double n6 = 4.5; // O double é um número de ponto flutuante tb mas com mais precisão
            string nome = "Maria"; // O string é um tipo de variável que armazena texto e é imutavel
            object obj1 = "Aninha"; // O object é um tipo de variável que aceita qualquer tipo de dado!
            
            Console.WriteLine(x); // equivale ao Print no Python
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
        }
    }
}
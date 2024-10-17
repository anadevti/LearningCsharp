using System;
using System.Globalization;

namespace MyApp
{
    internal class Variaveis
    {
        public void Main(string[] args)
        {
            char genero = 'F';
            int idade = 23;
            double saldo = 10.35784;
            string nome = "Aninha";

            Console.WriteLine("-----------------------");
            Console.WriteLine("Genero: " + genero);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Saldo: " + saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("-----------------------");
            
            // utilizando placeholders:
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            
            // utilizando interpolação:
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            
            // utilizando concatenação:
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
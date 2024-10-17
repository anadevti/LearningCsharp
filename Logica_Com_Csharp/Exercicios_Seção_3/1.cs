using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Resolucao_1
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            
            // em seguida, usando os valores das variaveis acima, exibir as mensagens conforme exemplo:
            // produtos:
            // Computador, cujo preço é $ 2100,00
            // Mesa de escritório, cujo preço é $ 650,50
            // Registro: 30 anos de idade, código 5290 e gênero: M
            // Medida com oito casas decimais: 53,23456700
            // Arredondado (três casas decimais): 53,235
            // Separador decimal invariant culture: 53.235
            
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine($"{idade} anos de idade com o código {codigo:F2} e gênero {genero} M");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador Decimal Invariant Culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
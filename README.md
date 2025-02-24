# Projeto Porcentagem de Desconto

Crie um programa que leia o preço de um produto e a porcentagem de desconto, calcule o valor do desconto e o preço final do produto após o desconto. Exiba o valor do desconto e o preço final.
Dicas:
Utilize Console.WriteLine para pedir o preço do produto e a porcentagem de desconto.
Utilize Console.ReadLine e Convert.ToDecimal para capturar as entradas e converter os valores.
Realize o cálculo do valor do desconto com a fórmula: Desconto = Preço * (Porcentagem / 100)
Subtraia o valor do desconto do preço original para obter o preço final.
Exiba o valor do desconto e o preço final com Console.WriteLine.
===============================================================================================================================================================================

using System;

namespace CalculadoraDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o preço do produto
            Console.WriteLine("Digite o preço do produto:");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

  // Solicita ao usuário a porcentagem de desconto
            Console.WriteLine("Digite a porcentagem de desconto:");
            decimal porcentagemDesconto = Convert.ToDecimal(Console.ReadLine());

  // Calcula o valor do desconto
            decimal desconto = preco * (porcentagemDesconto / 100);

  // Calcula o preço final após o desconto
            decimal precoFinal = preco - desconto;

  // Exibe o valor do desconto e o preço final
            Console.WriteLine($"Valor do desconto: {desconto.ToString("C")}");
            Console.WriteLine($"Preço final após desconto: {precoFinal.ToString("C")}");
        }
    }
}

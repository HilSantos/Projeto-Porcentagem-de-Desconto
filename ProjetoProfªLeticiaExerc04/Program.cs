using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProfªLeticiaExerc04
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal Porcentagem, desconto, preço;

            Console.WriteLine("Informe o preço do produto: ");
            preço = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a Porcentagem de desconto: ");
            Porcentagem = Convert.ToInt32(Console.ReadLine());

            desconto = preço * (Porcentagem / 100);

            Console.WriteLine("Subtraia o valor do desconto do preço: ");
            desconto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Exibir o valor do desconto e o preço final: "+preço);
            preço = Convert.ToDecimal(Console.ReadLine());

            Console.ReadKey();
        }
    }
}

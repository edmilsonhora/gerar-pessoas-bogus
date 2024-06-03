using System;

namespace ESH.GerarPessoasComBogus.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoas = PessoaFake.Listar(20);

            foreach (var p in pessoas)
            {
                Console.WriteLine($"{p.Nome}");
                Console.WriteLine($"{p.CPF}");
                Console.WriteLine($"{p.Sexo}");
                Console.WriteLine($"{p.RG}");
                Console.WriteLine($"{p.Email}");
                Console.WriteLine($"{p.CEP}");
                Console.WriteLine($"{p.Endereco}");
                Console.WriteLine("+++++++++++++++++++++++++++++++");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projeto 7 ");

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao possui +18. Pode Entrar!");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("Joao é menor de idade mas esta acompanhado");
                }
                else
                {
                    Console.WriteLine("Joao é menor de idade!");
                }
            }
        }
    }

}

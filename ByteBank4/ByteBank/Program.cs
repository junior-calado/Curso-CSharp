using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("Teste.txt"))
            {
                leitor.LerProximaLinha();
            }



            //---------------------------------------------------------------
            /*LeitorDeArquivo leitor = null;

            try
            {
                leitor = new LeitorDeArquivo("Contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            finally
            {
                Console.WriteLine("Executando o FINALLY!");
                if(leitor != null)
                leitor.Fechar();
            }*/
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 4567890);
                ContaCorrente conta2 = new ContaCorrente(124, 1234567);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informacoes da INNER EXCEPTION (exceção interna): ");

            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisao de 10 por " + divisor + " É " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Excecao com numero = " + numero + " e divisor = " + divisor);
                throw;
                Console.WriteLine("Codigo depois do throw");
            }
        }
    }
}


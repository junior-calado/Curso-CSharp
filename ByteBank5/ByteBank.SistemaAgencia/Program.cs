using Bytebank.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2024, 8, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40);

            Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            /*Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);*/


            Console.ReadLine();
        }
    }
}
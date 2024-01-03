using _07_ByteBank;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 8671234);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaGabriela = new ContaCorrente(867, 8675382);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();
        }
    }
}

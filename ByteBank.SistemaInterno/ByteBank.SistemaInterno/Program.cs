namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458, 4587654);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
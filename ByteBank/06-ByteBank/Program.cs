using _06_ByteBank;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Gilherme";
            cliente.Cpf = "123.456.789-00";
            cliente.Profissao = "Desenvolvedor";


            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);


            Console.ReadLine();
        }
    }
}

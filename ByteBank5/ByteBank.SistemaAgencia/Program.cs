using Bytebank.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(844, 364728);

            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("Asjkdkanjs");

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
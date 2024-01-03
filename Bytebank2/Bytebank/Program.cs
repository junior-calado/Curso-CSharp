using Bytebank;
using Bytebank.Funcionarios;
using Bytebank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CalcularBonificacao();*/
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.564.212-11");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("812.412.741-98");
            camila.Nome = "Camila";
            camila.Senha = "abc";


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");


            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();


            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.564.212-11");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("913.137.132-93");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("812.412.741-98");
            camila.Nome = "Camila";


            Desenvolvedor guilherme = new Desenvolvedor("234.245.122-88");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total De bonificações: " +  gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
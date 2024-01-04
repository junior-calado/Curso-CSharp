using Bytebank.Funcionarios;
using Humanizer;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ola mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 678954);
            object desenvolvedor = new Desenvolvedor("4565456");

            string contaTostring = conta.ToString();

            Console.WriteLine("Resultado: " + contaTostring);


            Console.ReadLine();
        }

        static void TestaString()
        {



            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "askjanfkafoianfkaj 4784-4546 aosdijaskd alkdlaskdjajsf";


            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();



            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();



            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDEArgumentosURL extratorDeValores = new ExtratorValorDEArgumentosURL(urlParametros);

            Console.WriteLine("Valor de moedaDestino: " + extratorDeValores.GetValor("moedaDestino"));
            Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValor("moedaOrigem"));

            Console.WriteLine(extratorDeValores.GetValor("VaLoR"));

            Console.ReadLine();

            //Testando upper e lower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(mensagemOrigem.ToLower());

            //Tesando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();
            /*

                        string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
                        ExtratorValorDEArgumentosURL extratorDeValores = new ExtratorValorDEArgumentosURL(urlParametros);

                        Console.WriteLine("Valor de moedaDestino: " + extratorDeValores.GetValor("moedaDestino"));
                        Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValor("moedaOrigem"));

                        Console.WriteLine(extratorDeValores.GetValor("valor"));

                        Console.ReadLine();*/


            //Testando metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');

            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();



            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();



            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNull = null;
            string textoQualquer = "sdfghjkl";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNull));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();



            ExtratorValorDEArgumentosURL extrator = new ExtratorValorDEArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf("?");

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            Console.WriteLine(url.Substring(indiceInterrogacao + 1));

            Console.ReadLine();
        }
    }
}
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            Config();
        }

        static void Config()
        {
            Console.WriteLine("Iniciando aplicação...");
            Console.WriteLine("--------------------------------------------");
            StartSelfHost();
        }

        static void StartSelfHost()
        {
            try
            {
                //Enquanto estiver dentro do Using, manterá a configuração da WebApi "online"
                using (WebApp.Start<WebApiConfiguration>("http://*:3031/"))
                {
                    Console.WriteLine("Aplicação iniciada com sucesso!!!");

                    Console.WriteLine("Acesse pelo browser, o IP da máquina em que o programa esta rodando. Pode acessar de qualquer outro dispositivo conectado na rede local(caso seja conexão interna) usando no final a porta 3031.");
                    Console.WriteLine("");
                    Console.WriteLine("Exemplo: 192.168.10.10:3031 E em seguida, inclua o caminho /api/product/getproducts.");
                    Console.WriteLine("Resultado: 192.168.10.10:3031/api/product/getproducts");
                    Console.WriteLine("");
                    Console.WriteLine("O resultado exibirá de exemplo uma listagem de produtos.");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Pressione ENTER para sair.");

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Houve um erro ao iniciar a aplicação: ");
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
        }
    }
}

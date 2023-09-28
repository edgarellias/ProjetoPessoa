using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoa.view
{
    internal class Menu
    {

        public void mostraMenu()
        {
            string? opcaoEscolhida;
            do
            {
                Console.WriteLine("*******MENU*******");
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Verificar pessoas cadastradas");
                Console.WriteLine("3 - Baixar lista de pessoas");
                Console.WriteLine("4 - Encerrar");
                opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.WriteLine("opcao 1");
                        break;
                    case "2":
                        Console.WriteLine("opcao 2");
                        break;
                    case "3":
                        Console.WriteLine("opcao 3");
                        break;
                    case "4":
                        Console.WriteLine("opcao 4");
                        break;
                    default:
                        Console.WriteLine("opcao invalida, escolha uma das alternativas");
                        break;
                }
            } while (opcaoEscolhida != "4");
        }
    }
}

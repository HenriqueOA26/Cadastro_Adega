using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_bebidas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            while (opcao != 5) 
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗██████╗░███████╗████████╗███████╗░█████╗░░█████╗░
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗   ██╔══██╗██╔════╝██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗██╔══██╗
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██████╔╝█████╗░░██████╔╝█████╗░░░░░██║░░░█████╗░░██║░░╚═╝██║░░██║
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██╔══██╗██╔══╝░░██╔═══╝░██╔══╝░░░░░██║░░░██╔══╝░░██║░░██╗██║░░██║
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██║░░██║███████╗██║░░░░░███████╗░░░██║░░░███████╗╚█████╔╝╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚══════╝░░░╚═╝░░░╚══════╝░╚════╝░░╚════╝░");

                Console.ResetColor();

                Console.WriteLine("\n Seja bem vindo a Adega Repeteco");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n 1- Cadastrar Produto");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n 2 - Cadastrar Cliente");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n 3- Cadastrar Funcionário");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n 4- Cadastrar Fornecedor");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n 5- Sair");
                Console.ResetColor();

                Console.WriteLine("\n Digite a Opção escolhida: ");

                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        cadastroProduto();
                        break;

                    case 2:
                        cadastroCliente();
                        break;

                    case 3:
                        cadastroFuncionario();
                        break;

                    case 4:
                        cadastroFornecedor();
                        break;

                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Volte sempre! ");
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção inválida!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000);
                        break;



                }
            }
        }

        static void cadastroProduto()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗████████╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║╚══██╔══╝██╔══██╗
██████╔╝██████╔╝██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║
██╔═══╝░██╔══██╗██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║
██║░░░░░██║░░██║╚█████╔╝██████╔╝╚██████╔╝░░░██║░░░╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═════╝░░╚═════╝░░░░╚═╝░░░░╚════╝░");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Digite o nome do produto:");
            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Digite o preço:");
            double preco = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Digite a validade:");
            string validade = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Digite o peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Digite a categoria:");
            string categoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nProduto cadastrado!");
            System.Threading.Thread.Sleep(3000);
            Console.ResetColor();
        }

        static void cadastroCliente()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Nome:");
            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Telefone:");
            string telefone = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n CEP:");
            string cep = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nCliente cadastrado!");
            System.Threading.Thread.Sleep(3000);
            Console.ResetColor();
        }

        static void cadastroFuncionario()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██████╗░██╗░█████╗
██╔════╝██║░░░██║████╗░██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██╔══██╗██║██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██████╔╝██║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██║██║░░██║██║╚████║██╔══██║██╔══██╗██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░░██║██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Nome:");
            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Telefone:");
            string telefone = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n CPF:");
            string cep = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n Cargo:");
            string cpf = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n Salário:");
            double salario = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nFuncionário cadastrado!");
            System.Threading.Thread.Sleep(3000);
            Console.ResetColor();

            
        }

        static void cadastroFornecedor()
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.DarkYellow;

            Console.WriteLine(@"
███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Nome:");
            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n CNPJ:");
            string cnpj = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n O que fornece:");
            string fornece = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nFornecedor cadastrado!");
            System.Threading.Thread.Sleep(3000);
            Console.ResetColor();
        }
    }
}



        
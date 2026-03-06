using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using lp2aula03.restauranteclasse;

namespace atividade03lp2.classe_restaurante
{
        class Opcoes
        {
            public static List<prato> Cardapio = new List<prato>();
           
            public static void Menu()
            {
                Console.Clear();
                int opcao;
                Console.WriteLine("Restaurante");
                Console.WriteLine("1 - adicionar produtos ao estoque");
                Console.WriteLine("2 - Listagem e pedido");
                Console.WriteLine("3 - sair");
                Console.WriteLine("Escreva sua opção");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                case 1:
                    Console.Clear();
                    Cadastro();
                    Opcoes.Menu();
                    break;
                case 2:
                    Console.Clear();
                    Pedido();
                    Opcoes.Menu();
                    break;
                case 3:
                    Console.Clear();
                    break;
                default:
                    Opcoes.Menu();
                    break;
                }

            }
            public static void Cadastro()
            {
                string opcao = "s";

                while (opcao == "s")
                {
                    
                    Console.WriteLine("Qual é o nome do prato que você deseja?");
                    string nomes = Console.ReadLine();

                    Console.WriteLine("Quantas Calorias possui:");
                    double calorias = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quantas Proteínas possui:");
                    double proteinas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quantos Carboidratos possui:");
                    double carboidratos = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quantas Gorduras possui:");
                    double gorduras = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quanto Sódio possui:");
                    double sodio = double.Parse(Console.ReadLine());

                    prato p = new prato(nomes, calorias, carboidratos, proteinas, sodio, gorduras);

                    Cardapio.Add(p);

                    Console.WriteLine("Produto cadastrado com sucesso!");
                    Console.WriteLine("Deseja adicionar mais um prato? (s/n)");
                    opcao = Console.ReadLine().ToLower();


                }

            }
            public static void Pedido()
            {
                Console.WriteLine("Produtos do cardápio:");

                foreach (prato p in Cardapio)
                {
                    Console.WriteLine($"Prato: {p.nomes}");
                    Console.WriteLine($"Calorias: {p.calorias}");
                    Console.WriteLine($"Proteinas: {p.proteinas}");
                    Console.WriteLine($"Carboidratos: {p.carboidratos}");
                    Console.WriteLine($"Gorduras: {p.gorduras}");
                    Console.WriteLine($"Sodio: {p.sodio}");
                    Console.WriteLine("-------------------------");
                }

                Console.WriteLine("Digite qual você gostaria de pedir : ");
                string nome = Console.ReadLine();

                bool encontrar = false;

                foreach (prato p in Cardapio)
                {
                    if (p.nomes.ToLower() == nome.ToLower())
                    {
                        Console.WriteLine("Pedido realizado com sucesso!");
                        encontrar = true;
                        break;
                    }
                }
                while (encontrar = false)
                {
                Console.WriteLine("Pedido não encontrado");
                }

                Console.ReadKey();
            }
    }
}

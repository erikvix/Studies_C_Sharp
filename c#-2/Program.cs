using System;
using System.Linq;

class Program
{
    static int i = 0;
    static string[] produto = new string[10];
    static double[] quants = new double[10];
    static double[] precos = new double[10];

    public static void Main(string[] args)
    {
        int opcao = 0;

        do
        {
            Console.WriteLine("Escolha uma opção:\n" +
                   "{ 1 } Inserir\n" +
                   "{ 2 } Faturamento de um Produto\n" +
                   "{ 3 } Faturamento Total\n" +
                   "{ 4 } Lista de Produtos\n" +
                   "{ 5 } sair");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        IncluirDados();
                        break;
                    case 2:
                        MostrarFaturamento();
                        break;
                    case 3:
                        MostrarFaturamentoTotal();
                        break;
                    case 4:
                        MostrarListaProdutos();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        } while (opcao != 5);
        Console.ReadKey();
    }

    static void IncluirDados()
    {
        string nome = "";
        double quant = 0;
        double preco = 0;

        if (i < 10)
        {
            try
            {
                Console.WriteLine($"Digite o nome do produto: ");
                nome = Console.ReadLine();

                if (produto.Contains(nome))
                {
                    Console.WriteLine($"Nome já registrado");
                    return;
                }

                Console.WriteLine($"Digite a quantidade: ");
                quant = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o preço: ");
                preco = double.Parse(Console.ReadLine());

                produto[i] = nome;
                quants[i] = quant;
                precos[i] = preco;
                i++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");
            }
        }
        else
        {
            Console.WriteLine($"Limite de produtos atingido.");
        }
    }

    static void MostrarFaturamento()
    {
        string nome = "";
        Console.WriteLine($"Produtos disponíveis: ");
        for (int ind = 0; ind < i; ind++)
        {
            Console.WriteLine($"{produto[ind]}");
        }

        Console.WriteLine($"Digite o nome do produto que deseja ver o faturamento: ");
        nome = Console.ReadLine();

        int index = Array.IndexOf(produto, nome);
        if (index >= 0)
        {
            double faturamento = quants[index] * precos[index];
            Console.WriteLine($"\nO faturamento total é R${faturamento}");
        }
        else
        {
            Console.WriteLine($"{nome} não encontrado no estoque.");
        }
    }

    static void MostrarFaturamentoTotal()
    {
        Console.WriteLine($"Faturamento de todos os produtos: ");
        Console.WriteLine("---------------------------------");
        for (int ind = 0; ind < i; ind++)
        {
            double faturamento = quants[ind] * precos[ind];
            Console.WriteLine($"Produto: {produto[ind]}\n" +
            $"Faturamento: R${faturamento}");
        }
    }

    static void MostrarListaProdutos()
    {
        Console.WriteLine($"Lista de produtos: ");

        for (int ind = 0; ind < i; ind++)
        {
            Console.WriteLine($"Nome do produto: {produto[ind]}");
            Console.WriteLine($"Quantidade do produto: {quants[ind]}");
            Console.WriteLine($"Preço do produto: R${precos[ind]}");
        }
    }
}

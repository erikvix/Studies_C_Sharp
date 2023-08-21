string[] filmes = new string[10];
int quant = 0;
int op = 0;
string pesnum = "";
int delnum = 0;
int altnum = 0;

do
{
    System.Console.WriteLine("---------------");
    System.Console.WriteLine("LISTA DE FILMES");
    System.Console.WriteLine("---------------");

    System.Console.WriteLine("[ 1 ] INSERIR FILMES");
    System.Console.WriteLine("[ 2 ] REMOVER FILMES");
    System.Console.WriteLine("[ 3 ] MOSTRAR FILMES");
    System.Console.WriteLine("[ 4 ] PESQUISAR FILMES");
    System.Console.WriteLine("[ 5 ] ALTERAR FILMES");
    System.Console.WriteLine("[ 6 ] SAIR DO PROGRAMA");
    op = int.Parse(Console.ReadLine());

    if (op == 1)
    {
        System.Console.WriteLine("Quantos filmes você deseja inserir? (MAX: 10)");
        quant = int.Parse(Console.ReadLine());

        for (int i = 0; i < quant; i++)
        {
            System.Console.WriteLine($"Digite o nome do {i + 1} filme");
            filmes[i] = Console.ReadLine();
        }
    }
    if (op == 2)
    {
        if (filmes.Length < 0)
        {
            System.Console.WriteLine("Não há filmes inseridos para remover.");
        }
        else
        {
            System.Console.WriteLine("Qual filme deseja remover?");
            delnum = int.Parse(Console.ReadLine());
            if (delnum > filmes.Length)
            {
                System.Console.WriteLine("Não há filme com esta numeração..");
            }
            else
            {
                filmes[delnum] = "";
                System.Console.WriteLine("Removendo filme...");
                Thread.Sleep(2000);
                System.Console.WriteLine("Filme removido!");
            }
        }
    }
    if (op == 3)
    {
        if (filmes.Length < 0)
        {
            System.Console.WriteLine("Não há filmes inseridos.");
        }
        else
        {
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("FILMES INSERIDOS:");
            System.Console.WriteLine("-----------------");
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"{i + 1}º {filmes[i]} ");
                Thread.Sleep(1000);
            }
        }
    }
    if (op == 4)
    {
        if (filmes.Length < 0)
        {
            System.Console.WriteLine("Não há filmes para pesquisar.");
        }
        else
        {
            System.Console.WriteLine("Qual filme deseja pesquisar?");
            pesnum = Console.ReadLine();
            if (filmes.Contains(pesnum))
            {
                System.Console.WriteLine($"O Filme {pesnum} foi encontrado!");
            }
            else
            {
                System.Console.WriteLine($"O Filme {pesnum} não foi encontrado.");
            }
        }
    }

    if (op == 5)
    {
        if (filmes.Length < 0)
        {
            System.Console.WriteLine("Não há filmes suficientes para alterar.");
        }
        else
        {
            System.Console.WriteLine("Digite o número do filme que deseja alterar");
            altnum = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o novo nome do filme");
            filmes[altnum - 1] = Console.ReadLine();
            Thread.Sleep(2000);
            System.Console.WriteLine("Alterando filme...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Filme alterado com sucesso.");
        }
    }
} while (op != 6);
Thread.Sleep(1000);
System.Console.WriteLine("Finalizando programa...");
Thread.Sleep(3000);

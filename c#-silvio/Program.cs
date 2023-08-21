// * 1. Crie um programa que deverá receber “n” números inteiros, após receber os
// números o programa deverá limpar a tela e exibir a média aritmética dos
// números recebidos. Utilize classe estática na resolução deste programa.


// class Program
// {
//     public static void Main(string[] args)
//     {
//         List<int> values = new List<int>();
//         int num = 1;
//         while (num != 0)
//         {
//             Console.WriteLine($"Digite o número que deseja inserir (0 para sair):");
//             num = int.Parse(Console.ReadLine());
//             values.Add(num);
//         }

//         double media = values.Average();
//         Console.WriteLine($"Média dos números inseridos: {media:F2}");
//         Console.ReadKey();
//     }
// }

// TODO 2. Crie um programa que deverá receber “n” números inteiros, após receber os
// números o programa deverá limpar a tela e informar quantos são pares e
// quantos são ímpares. O programa deverá ainda exibir a somatória dos números
// pares e dos números ímpares. Utilize classe estática na resolução deste
// programa.


// namespace MyNamespace
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             int n = 1;
//             List<int> par = new List<int>();
//             List<int> impar = new List<int>();

//             while (n != 0)
//             {
//                 Console.WriteLine($"Digite um número: ");
//                 n = int.Parse(Console.ReadLine());

//                 if (n % 2 == 0)
//                 {
//                     par.Add(n);
//                 }
//                 else
//                 {
//                     impar.Add(n);
//                 }
//             }
//             Console.Clear();
//             Console.WriteLine($"Total de números pares digitados: " + $"{par.Count}\n" +
//             $"\tSoma total dos números pares: {par.Sum()}");
//             Console.WriteLine($"Total de números ímpares digitados: " + $"{impar.Count}\n" +
//             $"\tSoma total dos números pares: {impar.Sum()}");
//             Console.ReadKey();
//         }
//     }
// }

// ! 3. Crie um programa que deverá receber “n” números inteiros, após receber os
// números o programa deverá limpar a tela, listar os números recebidos e
// apresentar a média aritmética desses números. Utilize classe estática na
// resolução deste programa

// namespace MyNamespace
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             int n = 1;
//             List<int> lista = new List<int>();

//             while (n != 0)
//             {
//                 Console.WriteLine($"Digite um número: ");
//                 n = int.Parse(Console.ReadLine());
//                 if (n != 0)
//                 {
//                     lista.Add(n);
//                 }
//             }
//             Console.Clear();
//             double media = lista.Average();
//             foreach (var item in lista)
//             {
//                 Console.WriteLine($"{item}");
//             }
//             Console.WriteLine($"\nA Média Aritmética é igual à: {(media)}");
//             Console.ReadKey();
//         }
//     }
// }

//! 4.Crie um programa que deverá receber “n” números inteiros, após receber os
//! números o programa deverá limpar a tela e exibir uma lista com os números
//! pares recebidos. Utilize classe estática na resolução deste programa.

// namespace MyNamespace
// {
//     class Program
//     {
//         public static void Main()
//         {
//             int n = 1;
//             List<int> list = new List<int>();

//             while (n != 0)
//             {
//                 Console.WriteLine($"Digite um número: ");
//                 n = int.Parse(Console.ReadLine());
//                 // verifica se o valor digitado não é zero ou negativo
//                 if (n != 0 && n % 2 == 0)
//                 {
//                     list.Add(n);
//                 }
//             }
//             Console.Clear();
//             Console.WriteLine($"Números pares: ");
//             foreach (var item in list)
//             {
//                 Console.WriteLine($"{item}");
//             }
//             Console.ReadKey();
//         }
//     }
// }

// 5.Crie um programa que deverá receber “n” números inteiros, após receber os
// números o programa deverá copiar o conteúdo deste vetor em dois outros
// vetores, um contendo somente os números pares e outro somente os números
// ímpares. Depois desta etapa o programa deverá limpar a tela e exibir o
// conteúdo dos dois novos vetores. Utilize classe estática na resolução deste
// programa.

using System;
using System.Collections.Generic;
using System.Linq;

public static class SeparadorNumeros
{
    public static void SepararNumeros(List<int> numeros, out List<int> pares, out List<int> impares)
    {
        pares = numeros.Where(x => x % 2 == 0).ToList();
        impares = numeros.Where(x => x % 2 != 0).ToList();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        List<int> numerosPares;
        List<int> numerosImpares;

        Console.Write("Quantos números deseja inserir? ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                    i--;
                }
            }

            Console.Clear(); // Limpa a tela

            SeparadorNumeros.SepararNumeros(numeros, out numerosPares, out numerosImpares);

            Console.WriteLine("Números Pares:");
            Console.WriteLine(string.Join(", ", numerosPares));

            Console.WriteLine("\nNúmeros Ímpares:");
            Console.WriteLine(string.Join(", ", numerosImpares));
        }
        else
        {
            Console.WriteLine("Número inválido de números a serem inseridos.");
        }
    }
}

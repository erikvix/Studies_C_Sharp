double n1, n2, n3, n4, n5 = 0;
double media = 0;

Console.WriteLine("Digite um número: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
n3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
n4 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
n5 = double.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4 + n5) / 5;
Console.WriteLine("A média dos números é: " + media);

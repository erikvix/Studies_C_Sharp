int bas, alt = 0;
int area = 0;

Console.WriteLine("Digite a base do seu triângulo: ");
bas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do seu triângulo: ");
alt = int.Parse(Console.ReadLine());

area = bas * alt;
Console.WriteLine("A área do seu triângulo é: " + area + "m²");

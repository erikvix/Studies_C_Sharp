double real = 0;
double dolar = 5.10;
double conv = 0;

Console.WriteLine("Digite o seu valor em REAIS: ");
real = double.Parse(Console.ReadLine());
conv = dolar * real;

Console.WriteLine("Você vai levar $" + conv + " dolares para sua viagem.");


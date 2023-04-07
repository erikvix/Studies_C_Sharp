double cel, fah;

Console.WriteLine("Digite o número em CELSIUS: ");
cel = double.Parse(Console.ReadLine());
fah = (cel * 1.8) + 32;
Console.WriteLine("A temperatura em Celsius convertida para Fahrenheit é: " + fah + "°");

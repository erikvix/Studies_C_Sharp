double raio, altura;
double vol;
Console.WriteLine("Digite o raio da lata: ");
raio = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o altura da lata: ");
altura = double.Parse(Console.ReadLine());

vol = 3.14159 * raio * raio * altura;

Console.WriteLine("O volume da lata de óleo é: " + vol + "ml");
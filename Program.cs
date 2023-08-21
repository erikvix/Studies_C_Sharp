// double num1, num2, soma = 0;
// Console.WriteLine("Olá!");
// Console.Write("digite um número: ");
// num1 = double.Parse(Console.ReadLine());
// Console.Write("Digite outo número: ");
// num2 = double.Parse(Console.ReadLine());
// soma = num1 + num2;
// // Console.WriteLine("soma de {0} + {1} = {2}", num1, num2, soma);
// Console.WriteLine("soma de " + num1 + num2 + "é de " + soma);
// Console.Read();

// // ANTECESSOR

// int n1;
// int x;

// Console.Write("Digite um número: ");
// n1 = int.Parse(Console.ReadLine());
// x = n1 + 1;
// Console.WriteLine("O antecessor do seu número é " + x);

// int n1, n2, n3, n4 = 0;
// int x = 0;

// Console.WriteLine("Digite um número: ");
// n1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n3 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n4 = int.Parse(Console.ReadLine());

// x = n1 + n2 + n3 + n4;
// Console.WriteLine("A soma dos números é: " + x);

// double n1, n2, n3, n4, n5 = 0;
// double media = 0;

// Console.WriteLine("Digite um número: ");
// n1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n3 = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n4 = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite um número: ");
// n5 = double.Parse(Console.ReadLine());

// media = (n1 + n2 + n3 + n4 + n5) / 5;
// Console.WriteLine("A média dos números é: " + media);


// int n1, n2 = 0;
// int cons_med = 0;
// Console.WriteLine("Digite a distância percorrida: ");
// n1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o combustível gasto: ");
// n2 = int.Parse(Console.ReadLine());
// cons_med = n1 / n2;
// Console.WriteLine("O consumo médio de combustível é: " + cons_med);

// int n1, n2 =0;
// int qoc =0;
// int qoc2 =0;
// Console.WriteLine("Digite um número: ");
// n1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite outro número: ");
// n2 = int.Parse(Console.ReadLine());

// qoc = n1 / n2;
// qoc2 = n1 % n2;

// Console.WriteLine("O resto de " + n1 + "/" + n2 + " é: " + qoc2 + ", consciente é: " + qoc);

// Console.ReadKey();


// double cel, fah;

// Console.WriteLine("Digite o número em CELSIUS: ");
// cel = double.Parse(Console.ReadLine());
// fah = (cel * 1.8) + 32;
// Console.WriteLine("A temperatura em Celsius convertida para Fahrenheit é: " + fah + "°");


// double a, b =0;

// Console.WriteLine("Digite o valor de a: ");
// a = double.Parse(Console.ReadLine());

// Console.WriteLine("Digite o valor de b: ");
// b = double.Parse(Console.ReadLine());

// Console.WriteLine("O valor de A é: " + b + " e o valor de B é: " + a);


// double preço = 20;
// double valor = 0;
// double troco = 0;

// Console.WriteLine("O seu produto custa R$20,00.");
// Console.WriteLine("Coloque o valor: ");
// valor = double.Parse(Console.ReadLine());

// if (valor<= preço){
//     Console.WriteLine("VALOR INSUFICIENTE.");
// }
// else{
//     Console.WriteLine("Produto comprado!");
//     troco = valor - preço;
//     Console.WriteLine("Seu troco é de: R$" + troco);
// }
// Console.ReadKey();


// double raio, altura;
// double vol;
// Console.WriteLine("Digite o raio da lata: ");
// raio = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite o altura da lata: ");
// altura = double.Parse(Console.ReadLine());

// vol = 3.14159 * raio * raio * altura;

// Console.WriteLine("O volume da lata de óleo é: " + vol + "ml");


// double real = 0;
// double dolar = 5.10;
// double conv = 0;

// Console.WriteLine("Digite o seu valor em REAIS: ");
// real = double.Parse(Console.ReadLine());
// conv = dolar * real;

// Console.WriteLine("Você vai levar $" + conv + " dolares para sua viagem.");



// string nam;
// double sal;
// double vend;
// double aumento;

// Console.WriteLine("Digite seu nome: ");
// nam = Console.ReadLine();
// Console.WriteLine("Digite seu salário fixo: ");
// sal = double.Parse(Console.ReadLine());
// Console.WriteLine("Digite suas vendas no mês: ");
// vend = double.Parse(Console.ReadLine());

// aumento = sal * (vend * 1.25);

// Console.WriteLine("O salário fixo de " + nam + " é de " + sal + " e seu salário no final do mês é de " + aumento);


double num = 1;
double cont = 0;

while (num != 0)
{
    Console.WriteLine("Digite um número:");
    num = double.Parse(Console.ReadLine());
    cont++;
}
Console.WriteLine($"vc digitou {} valores");
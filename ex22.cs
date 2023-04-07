string nam;
double sal;
double vend;
double aumento;

Console.WriteLine("Digite seu nome: ");
nam = Console.ReadLine();
Console.WriteLine("Digite seu salário fixo: ");
sal = double.Parse(Console.ReadLine());
Console.WriteLine("Digite suas vendas no mês: ");
vend = double.Parse(Console.ReadLine());

aumento = sal * (vend * 1.25);

Console.WriteLine("O salário fixo de " + nam + " é de " + sal + " e seu salário no final do mês é de " + aumento);



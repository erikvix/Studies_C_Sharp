int n1, n2 =0;
int qoc =0;
int qoc2 =0;
Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
n2 = int.Parse(Console.ReadLine());

qoc = n1 / n2;
qoc2 = n1 % n2;

Console.WriteLine("O resto de " + n1 + "/" + n2 + " é: " + qoc2 + ", consciente é: " + qoc);

Console.ReadKey();



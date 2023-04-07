double preço = 20;
double valor = 0;
double troco = 0;

Console.WriteLine("O seu produto custa R$20,00.");
Console.WriteLine("Coloque o valor: ");
valor = double.Parse(Console.ReadLine());

if (valor<= preço){
    Console.WriteLine("VALOR INSUFICIENTE.");
}
else{
    Console.WriteLine("Produto comprado!");
    troco = valor - preço;
    Console.WriteLine("Seu troco é de: R$" + troco);
}
Console.ReadKey();


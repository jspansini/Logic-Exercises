using _001___Caneta.Models;

//instancia usando construtor vazio
Caneta caneta01 = new Caneta();
caneta01.Cor = "Vermelho";
caneta01.Codigo = 131313;
caneta01.Preco = 8.13;
caneta01.Tampada = true;
string msg = caneta01.Escrever("Uma mensagem linda!");

Console.WriteLine("\n---------------------------------\n");

Console.WriteLine("Essa é a primeira caneta\n");
Console.WriteLine("A cor é: " + caneta01.Cor);
Console.WriteLine("O código é " + caneta01.Codigo);
Console.WriteLine("A caneta está tampada?" + caneta01.Tampada);
Console.WriteLine("O preço da caneta é " + caneta01.Preco);
Console.WriteLine(msg);

Console.WriteLine("\n---------------------------------\n");

//instancia usando  construtor

Caneta caneta02= new Caneta(15, ModeloCaneta.Bic, "Rosa",TiposDePonta.PontaGrossa, false, 115.00);
Console.WriteLine("Essa é a segunda  caneta:\n");
Console.WriteLine(caneta02.Tampada);
Console.WriteLine(caneta02.Codigo);
Console.WriteLine(caneta02.Modelo);
Console.WriteLine(caneta02.Cor);
Console.WriteLine(caneta02.TamparOuDestampar());
Console.WriteLine(caneta02.Rabiscar());
Console.WriteLine(caneta02.Escrever("queremos um pacote de biscoitos!"));
Console.WriteLine("\n---------------------------------\n");




using _002___Pesoa.Models;

Pessoa pessoa1 = new Pessoa("Jessica Pansini", "jspansini@gmail.com", "Jess");
Console.WriteLine(pessoa1.Comprimentar());
Console.WriteLine($"Seu nome curto é muito melhor, {pessoa1.PrimeiroNome}!");
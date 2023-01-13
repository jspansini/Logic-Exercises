using _005___Smartphone.Models;

Motorola novoMotorola = new Motorola("21 9891-9929", "MotorolaBad", "1413-F", 64);
Console.WriteLine("----------- Motorola ----------------");
Console.WriteLine($"Este é meu modelo {novoMotorola.Modelo} - IMEI:{novoMotorola.Imei} com {novoMotorola.Memoria} GB de memória! \nPara me ligar, disque {novoMotorola.Numero}");
novoMotorola.Ligar();
novoMotorola.ReceberLigacao();
novoMotorola.InstalarAplicativo("Angrybirds");

Console.WriteLine();

Iphone novoIphone = new Iphone("21 9891-9929", "IphoneXV", "1323-F", 128);
Console.WriteLine("----------- IPHONE ----------------");
Console.WriteLine($"Este é meu modelo {novoIphone.Modelo} - IMEI:{novoIphone.Imei} com {novoIphone.Memoria} GB de memória! \nPara me ligar, disque {novoIphone.Numero}");
novoIphone.Ligar();
novoIphone.ReceberLigacao();
novoIphone.InstalarAplicativo("Itunes");
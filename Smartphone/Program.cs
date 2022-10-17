using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone da Nokia");
Smartphone nokia = new Nokia("1234", "Modelo Nokia", "000000000", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp"); //Fazer isso pelo polimorfismo

Console.WriteLine("\n");

Console.WriteLine("Smartphone da Apple");
Smartphone iphone = new Iphone("5678", "Modelo Apple", "333333333", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook"); //Fazer isso pelo polimorfismo
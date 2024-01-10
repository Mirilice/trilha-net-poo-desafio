using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Ipho
Smartphone nokia3310 = new Nokia("1234567890", "Nokia XYZ", "356987012345678", 64);
Smartphone iphone12pro = new Iphone("9876543210", "iPhone 12 Pro", "490154203237518", 128);

Console.WriteLine("Nokia:");
nokia3310.Ligar();
nokia3310.InstalarAplicativo("Telegram");
nokia3310.ReceberLigacao();

Console.WriteLine("\nIphone:");
iphone12pro.Ligar();
iphone12pro.InstalarAplicativo("WhatsApp");
iphone12pro.ReceberLigacao();
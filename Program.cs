using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Aparelho Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Iniciando();
nokia.Apresentando("123456", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Aparelho Iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo A", imei: "AAAAAAAA", memoria: 128);
iphone.Iniciando();
iphone.Apresentando("654321", "Modelo A","AAAAAAAA",128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

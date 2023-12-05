using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "9999-9999", modelo: "Nokia G11", imei: "151515151515151", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "7777-7777", modelo: "Iphone 14", imei: "212121212121212", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");

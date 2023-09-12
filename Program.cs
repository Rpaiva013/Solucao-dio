using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "1234", modelo: "Modelo 1", imei: "324531", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Smartphone phone = new Iphone (numero: "1234", modelo: "Modelo 1", imei: "324531", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
using DesafioPOO.Models;

// Implementado testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "3216-5498", modelo: "Modelo a32", imei: "111111", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1234-5678", modelo: "Modelo Iphone 15", imei: "222222", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("YouTube");


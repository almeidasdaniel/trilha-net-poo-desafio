using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");

var nokia = new Nokia(numero: "111222", modelo: "novo modelo", imei: "1111111", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("Zoom");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");

var iphone = new Iphone(numero: "111222", modelo: "13", imei: "1111122", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("YouTube");
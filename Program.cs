using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia(numero:"123456789", modelo: "n95", imei: "5a4c2e3b", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("=========================");

Console.WriteLine("APPLE IPHONE");
Smartphone iphone = new Iphone(numero:"987654321", modelo:"7 plus", imei:"9f8c5a4b", memoria:256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("=========================");

Console.WriteLine("IPHONE MAIS NOVO");
Smartphone iphone2 = new Iphone(numero:"997654321", modelo:"X", imei:"1q2w3e4r5t", memoria:128);
iphone2.Ligar();
iphone2.InstalarAplicativo("Telegram");
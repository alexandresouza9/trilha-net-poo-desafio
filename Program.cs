using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456789", modelo: "Tijolão", imei:"001300130013", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsaap");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "987456123", modelo: "4S", imei:"001200120012", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
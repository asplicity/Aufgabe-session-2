using System;

Console.WriteLine("Wie ist dein Vorname?");
var First_name = Console.ReadLine();
Console.WriteLine("Wie ist dein Nachname");
var second_name = Console.ReadLine();

#pragma warning disable
Console.WriteLine($"Herzlich Wilkommen, {First_name} {second_name}. Bitte setze dich an den nächsten Tisch. Dein Name beinhaltet {First_name.Length + second_name.Length} Zeichen.");

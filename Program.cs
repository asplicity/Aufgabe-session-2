using System;

Console.WriteLine("Wie ist dein Vorname?");
var First_name = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Wie ist dein Nachname");
var second_name = Console.ReadLine() ?? string.Empty;


Console.WriteLine($"Herzlich Wilkommen, {First_name} {second_name}. Bitte setze dich an den nächsten Tisch. Dein Name beinhaltet {First_name.Length + second_name.Length} Zeichen.");
Console.WriteLine("zum beenden taste drücken");
Console.ReadLine();

using System.Globalization;

Console.Write("--- Calcul du périmétre et de l'aire d'un carré encore ---");
Console.Write("Entrez la longueur d'un côté du carré (en cm) :");

double cote = Convert.ToDouble(Console.ReadLine());

Convert.ToInt32(cote);

double peri, aire;
peri = cote * 4;
aire = cote * cote;
Console.WriteLine($"Le périmétre du carré est  {peri} et l'aire est de {aire}");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

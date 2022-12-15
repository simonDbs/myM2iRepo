using System.Globalization;

Console.Write("--- Calcul de la longeur de l'hypothénuse encore ---");
Console.Write("Entrez la longueur du premier coté (en cm) :");
double cote1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longueur du deuxieme coté (en cm) :");
double cote2 = Convert.ToDouble(Console.ReadLine());


Convert.ToDouble(cote1);
Convert.ToDouble(cote2);
double hypo = Math.Pow(cote1, 2) + Math.Pow(cote2, 2);

Console.WriteLine($"La longeur de l'hypothénuse est :  {hypo}");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

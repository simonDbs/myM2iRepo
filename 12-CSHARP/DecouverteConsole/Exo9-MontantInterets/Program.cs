using System.Globalization;

Console.Write("--- Calcul des intéréts ---");
Console.Write("Entrez Capital de départ (en Euros) : ");
double capitalInitial = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez le taux d'intérét (en %) : ");
double tauxInterets = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la durée de l'épargne (en années) : ");
double duree = Convert.ToDouble(Console.ReadLine());



Convert.ToDouble(capitalInitial);
Convert.ToDouble(tauxInterets);
Convert.ToDouble(duree);

double capitalFinal, interets;
capitalFinal = Math.Round(capitalInitial * Math.Pow(1 + (tauxInterets / 100), duree), 2);
interets = Math.Round(capitalFinal - capitalInitial,2);


Console.WriteLine($"Le montant des intérêts sera de  {interets} Euros apres {duree} ans");
Console.WriteLine($" Le capital final sera de  {capitalFinal} Euros");



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

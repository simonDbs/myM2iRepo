using System.Globalization;

Console.Write("Entrez le prix HT de l'object (en Euros) : ");

double prixObjetHt = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez le taux de TVA (en %) :");
double tauxTva = Convert.ToDouble(Console.ReadLine());


Convert.ToInt32(prixObjetHt);
Convert.ToInt32(tauxTva);
double mtTva, prixObjetTtc;

mtTva = Math.Round(prixObjetHt * tauxTva / 100);
prixObjetTtc = prixObjetHt + mtTva;

Console.WriteLine($"Le montant de la T.V.A est de {mtTva} Euros");
Console.WriteLine($" Le prix TTC de l'objet est de {prixObjetTtc} Euros");



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

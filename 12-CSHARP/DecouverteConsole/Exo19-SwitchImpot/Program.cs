using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Quelle sera le montant de mes impôts ? ---");
Console.WriteLine("Veuillez saisir le montant net impossable du loyer (en €uro)  : ");
double revenus = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir le nombre d'alulte(s)  : ");
double nbAdulte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir le nombre d'enfant(s) : ");
double nbEnfants = Convert.ToDouble(Console.ReadLine());


double nbParts;
double revenuImposable;
double montantImpot = 0;

nbParts = nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;



revenuImposable = revenus / nbParts;

switch (revenuImposable)
{
    case double n when n  >= 10226 && n <= 26070:
         montantImpot = Math.Round((revenuImposable - 10225) * 0.11); break;
    case double n when n >= 26071 && n <= 74545:
        montantImpot = Math.Round((revenuImposable - 26070) * 0.3 + (26070 - 10226) * 0.11); break;
    case double n when n >= 74546 && n <= 160336:
        montantImpot = Math.Round((revenuImposable - 74545) * 0.41 + (74545 - 26070) * 0.3 + (26070 - 10226) * 0.11); break;
    case double n when n >= 160337:
        montantImpot = Math.Round((revenuImposable - 160336) * 0.45 + (160336 - 74545) * 0.41 + (74545 - 26070) * 0.3 + (26070 - 10226) * 0.11); break;

}








montantImpot *= nbParts;

Console.WriteLine($"Vous allez payer {montantImpot} Euros ");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
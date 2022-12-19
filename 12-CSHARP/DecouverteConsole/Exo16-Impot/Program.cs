using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Quelle sera le montant de mes impôts ? ---");
Console.WriteLine("Veuillez saisir le montant net impossable du loyer (en €uro)  : ");
double revenus = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir le nombre d'alulte(s)  : ");
double nbAdulte = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir le nombre d'enfant(s) : ");
double nbEnfants = Convert.ToDouble(Console.ReadLine());


double nbParts ;
double revenuImposable ;
double montantImpot = 0;


if (nbEnfants <= 2)
    nbParts = nbAdulte + nbEnfants * 0.5;
else
    nbParts = nbAdulte + nbEnfants - 1;


revenuImposable = revenus / nbParts;

if (revenuImposable >= 10226 && revenuImposable <= 26070)
    montantImpot = (revenuImposable - 10225) * 0.11;
else if (revenuImposable >= 26071 && revenuImposable <= 74545)
    montantImpot = (revenuImposable - 26070) * 0.3 + (26070 - 10226) * 0.11;
else if (revenuImposable >= 74546 && revenuImposable <= 160336)
    montantImpot = (revenuImposable - 74545) * 0.41 + (74545 - 26070) * 0.3 + (26070 - 10226) * 0.11;
else if (revenuImposable >= 160337)

    montantImpot = (revenuImposable - 160336) * 0.45 + (160336 - 74545) * 0.41 + (74545 - 26070) * 0.3 + (26070 - 10226) * 0.11;







montantImpot *= nbParts;

Console.WriteLine($"Vous allez payer {montantImpot} Euros ");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
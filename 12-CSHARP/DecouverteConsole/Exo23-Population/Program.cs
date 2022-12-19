using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Accroissement de population ---");

double nbhabitant = 96809;
double date = 2015;

double taux = 0.89;


//for (nbAnnee = 0; nbAnnee <= 50; nbAnnee++)
//{
//    nbhabitant += nbhabitant * (taux / 100);


//    Console.WriteLine("En " + ++date + " il y aura " + Math.Round(nbhabitant) + " habitants");
//    if (nbhabitant >= 120000)
//        break;
//}

while (date == 2040 )
{
    nbhabitant += nbhabitant * (taux / 100);
    Console.WriteLine("En " + ++date + " il y aura " + Math.Round(nbhabitant) + " habitants");
}

Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
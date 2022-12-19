using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Accroissement de population ---");

double nbhabitant = 96809;
double date = 2015;
double taux = 0.89;
double nbAnnee = 0;


while (nbhabitant < 120000)
{
    nbhabitant += nbhabitant * (taux / 100);
    Console.WriteLine("En " + ++date + " il y aura " + Math.Round(nbhabitant) + " habitants");
    nbAnnee++;
}

Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
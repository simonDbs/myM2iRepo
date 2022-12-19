
#region Incrémentation d'un compteur
int compteur = 1;
do
{
    Console.WriteLine($"Le compteur affiche {compteur}");
    compteur++;
} while (compteur <= 50);
Console.WriteLine($"Une fois sortie de la premiere boucle doWhile Le compteur vaut {compteur}");

do
{
    Console.WriteLine($"Le compteur affiche {compteur}");
    compteur++;
} while (compteur <= 50);

Console.WriteLine($"Une fois sortie de la DUXIEMME boucle doWhile Le compteur vaut {compteur}");
#endregion



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
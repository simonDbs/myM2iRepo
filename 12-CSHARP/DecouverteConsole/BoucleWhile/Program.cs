#region La boucle while
int compteur = 1;
while (compteur < 50)
{
    Console.WriteLine($"Le compteur affiche {compteur}");
    compteur++;
}
#endregion

#region  la boucle simple
int compteur2 = 1;
bool valid = false;

while (!valid)
{
    Console.WriteLine($"Le compteur affiche {compteur2}");
    if (compteur2 == 50)
    {
        valid = true;
    }
    compteur++;
}

#endregion



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

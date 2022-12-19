
///Foreach => lecture seule

#region Les boucle Foreach avec des type interger

Console.WriteLine("Création d'un tableau d'entiers");
int[] T1 = { 1, 2, 3, 4, 5 };
Console.WriteLine("itération du tableau");

foreach (int nombre in T1)
{
    Console.WriteLine(nombre);
}

#endregion

#region Les boucle Foreach avec des type interger

Console.WriteLine("Création d'un tableau de chaine de caractere");
string[] T2 = { "1","2","3" };
Console.WriteLine("itération du tableau");

foreach (string valeur in T2)
{
    Console.WriteLine(valeur);
}

#endregion



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
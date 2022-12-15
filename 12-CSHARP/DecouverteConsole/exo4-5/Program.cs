
int nb1 = 10, nb2 = 20;
int somme = nb1 + nb2; // egal a 30


Console.WriteLine($"La somme de {nb1} + {nb2} est égal à {somme}");

somme += nb2; //egal a 50

Console.WriteLine($"La somme de {nb1+nb2} +{nb2} est égal à {somme}");



Console.WriteLine($"Si je rajoute 1 à {somme} alors la nouvelle valeur de {++somme}");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
using System.Data;

Console.WriteLine("---- Ou est passé mon numéro ? ----");

Console.WriteLine("affectation des valeurs...");
Random rnd = new Random();
int[] T2 = new int[10];
Console.WriteLine("Affichage avant tirage : ");


for (int i = 0; i < T2.Length; i++)
{  
    int myst = rnd.Next(1, 51);
    Convert.ToString(myst);
    T2[i] = myst;  
}
string chaine = "";
int myNum = T2[0];
Console.WriteLine("Affichage avant tirage : ");
foreach (int valeur in T2)
{
    Console.WriteLine(chaine + valeur);
    chaine += "  ";
}
Array.Sort(T2);
int index = Array.IndexOf(T2, myNum);


Console.WriteLine("Je tri le tableau");
chaine = "";
Console.WriteLine("Affichage apres tirage : ");
foreach (int valeur in T2)
{
    Console.WriteLine(chaine + valeur);
    chaine += "  ";
}
Console.WriteLine($"La valeur {myNum} est presente a l'index {index} du new tab");





Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
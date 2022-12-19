#region cR2ATION D4UN TABLEAU D4ENTIERS ET IT2RATION DE SON CONTENU 
using System.Xml;

Console.WriteLine("Création d'un tableau T1 et itération : ");
int[] T1 = { 1, 2, 3 };

for (int i = 0; i < T1.Length; i++)
{
    Console.WriteLine(T1[i]); 
}
#endregion


#region Création d'un tableau d'entier T2
Console.WriteLine("Création d'un tab T2 vide et itération");

int[] T2 = new int[5];

for (int i = 0;i < T2.Length;i++)
    Console.WriteLine(T2[i]);

#endregion


#region Copie de T1 dans T2
Console.WriteLine("Copie de T1 dans T2 ..");
T1.CopyTo(T2, 0);
Console.WriteLine("\n itération de T2 apres copie..");

for (int i = 0; i < T2.Length; i++)
{
    Console.WriteLine(T2[i]);
}
#endregion


#region Modif de T1
Console.WriteLine("\n Modif de T1[0] = 100");
T1[0] = 100;
Console.WriteLine("\n ite de T1 apres modif");
for (int i = 0; i < T1.Length; i++)
{
    Console.WriteLine(T1[i]);
}

Console.WriteLine("\n ite de T2 apres modif");
for (int i = 0; i < T2.Length; i++)
{
   
    Console.WriteLine(T2[i]);
}



#endregion
Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

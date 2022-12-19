
Random r = new Random();
Random rnd = new Random();



int[] T2 = new int[10];

for (int i = 0; i < T2.Length; i++)
{
    int myst = rnd.Next(1, 51);
    Convert.ToString(myst);
    T2[i] = myst;
}

for (int i = 0; i < T2.Length; i++)
{
    string chaine = "";
    for (int j = 0; j < i; j++)
    {
         chaine = "\t\n";
        Console.WriteLine(T2[i] + chaine);
    }
}


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

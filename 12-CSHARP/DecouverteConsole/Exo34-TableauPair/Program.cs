Console.WriteLine("--- Est pair ...? Est impair...? ---");
Console.WriteLine("Combiens de nombre contiendra le tableau ? : ");
Console.WriteLine("Affectation aitomatique des valeurs...");
Console.WriteLine("Vérification des valeurs du tableau : ");
Random rnd = new Random();

int userChoiseNbr = Convert.ToInt32(Console.ReadLine());


int[] T2 = new int[userChoiseNbr];
string tri;
for (int i = 0; i < T2.Length; i++)
{
    int myst = rnd.Next(1, 51);
    Convert.ToString(myst);
    T2[i] = myst;
}

for (int i = 0; i < T2.Length; i++)
{
  //tri=  (T2[i] % 2 != 0) ? Console.WriteLine($"Le nombre {T2[i]} est pair.") : Console.WriteLine($"Le nombre {T2[i]} est impair.");

    if (T2[i] % 2 != 0)
    {
        Console.WriteLine($"Le nombre {T2[i]} est impair.");
    }
    else{
        Console.WriteLine($"Le nombre {T2[i]} est pair.");
    }
}



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

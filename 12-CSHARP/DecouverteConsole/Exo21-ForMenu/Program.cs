using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Menus et sous-menus ---");
Console.WriteLine("Table des matières :");

for (var i = 1; i <= 3; i++)
{
    Console.WriteLine("\t\nChapitre "+i);
    for (var j = 1; j <= 3; j++)
    {
       

        Console.Write("\t\n-Partie  ");
        Console.Write(i);
        Console.Write(".");
        Console.Write(j);
    }
}


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
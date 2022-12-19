using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Je compte jusqu'à 10 ---");
Console.WriteLine("Je commence à compter :");

for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Super, je sais compter jusqu'à 10!");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
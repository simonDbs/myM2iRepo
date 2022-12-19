using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Quelle est la nature du triangle ABC ?");
Console.WriteLine("Entrez la longeur du segement AB  : ");
double AB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entrez la longeur du segement BC  : ");
double BC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entrez la longeur du segement CA  : ");
double CA = Convert.ToDouble(Console.ReadLine());


if (AB == BC && BC == CA)
{
    Console.WriteLine("Le triangle ABC est équilatéral ");
}
else if (AB == BC)
{
    Console.WriteLine("Le triangle est isocèle en B");
}
else if (BC == CA)
{
    Console.WriteLine("Le triangle est isocèle en C");
}
else if (AB == CA)
{
    Console.WriteLine("Le triangle est isocèle en A");
}
else
{
     Console.WriteLine("Ce triangle n'est isocèle ni en A, ni en B, ni en C.");
}


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- La lettre est-elle une voyelle ? ---");
Console.WriteLine("Entrez un lettre : ");
string userLetter = Console.ReadLine();



if (userLetter == "a")
{
    Console.Write("Cette lettre est une voyelle !");
}
else if (userLetter == "e")
{
    Console.Write("Cette lettre est une voyelle !");
}
else if (userLetter == "i")
{
    Console.Write("Cette lettre est une voyelle !");
}
else if (userLetter == "o")
{
    Console.Write("Cette lettre est une voyelle !");
}
else if (userLetter == "u")
{
    Console.Write("Cette lettre est une voyelle !");
}
else if (userLetter == "y")
{
    Console.Write("Cette lettre est une voyelle !");
}
else
{
    Console.Write("Cette lettre est une consonne !");
}



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
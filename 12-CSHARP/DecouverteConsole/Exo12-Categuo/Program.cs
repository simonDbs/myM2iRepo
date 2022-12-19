using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Dans quelle catégorie mon enfant est-il... ?");
Console.WriteLine("Entrez l'âge de votre enfant : ");
double age = Convert.ToDouble(Console.ReadLine());



if (age < 3)
{
    Console.WriteLine("Votre enfant est trop jeune pour pratiquer ");
}
else if (age >= 3 && age <= 6)
{
    Console.WriteLine("Votre enfant est dans la catégorie BABY ");
}
else if (age >= 7 && age <= 8)
{
    Console.WriteLine("Votre enfant est dans la catégorie Poussin ");
}
else if (age >= 9 && age <= 10)
{
    Console.WriteLine("Votre enfant est dans la catégorie Pupille ");
}
else if (age >= 11 && age <= 12)
{
    Console.WriteLine("Votre enfant est dans la catégorie Minime ");
}
else if (age >= 13 && age < 18)
{
    Console.WriteLine("Votre enfant est dans la catégorie Cadet ");
}
else
{

     Console.WriteLine("Ce n'est plus un enfant! ");
}


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
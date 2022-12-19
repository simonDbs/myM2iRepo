using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Dans quelle catégorie mon enfant est-il... ?");
Console.WriteLine("Entrez l'âge de votre enfant : ");
double age = Convert.ToDouble(Console.ReadLine());


if (age < 3)
    Console.WriteLine("Votre enfant est trop jeune pour pratiquer");
else if (age >= 3 && age < 18)
{
    switch (age)
    {
        case double n when n > 0 && n <= 3:
            Console.WriteLine("Votre enfant est trop jeune pour pratiquer");
            break;
        case double n when n > 3 && n <= 6:
            Console.WriteLine("Votre enfant est dans la catégorie BABY");
            break;
        case double n when n > 6 && n <= 8:
            Console.WriteLine("Votre enfant est dans la catégorie Poussin");
            break;
        case double n when n > 8 && n <= 11:
            Console.WriteLine("Votre enfant est dans la catégorie Pupille");
            break;
        case double n when n > 11 && n <= 12:
            Console.WriteLine("Votre enfant est dans la catégorie Minime");
            break;
        default:
            Console.WriteLine("Votre enfant est dans la catégorie Cadet");
            break;
    }
}
else

    Console.WriteLine("Ce n'est plus un enfant!");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
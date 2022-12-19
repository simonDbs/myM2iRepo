Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Le nombre est-il divisible par... ? ---");
Console.WriteLine("Entrez un chiffre/nombre entier : ");
double nb1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entrez le chiffre/nombre diviseur : ");
double nb2 = Convert.ToDouble(Console.ReadLine());


if (nb1 % nb2 == 0)
{
    Console.WriteLine($"Le chiffre/nombre est divisble par  :  {nb2}");
}
else
{
    Console.WriteLine($"Le chiffre/nombre n'est pas divisble par  :  {nb2}");
}



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
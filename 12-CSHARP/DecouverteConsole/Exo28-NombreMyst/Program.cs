using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Trouver le nombre mystère ---");

Console.Write("Merci de saisir un nombre : ");



Random rnd = new Random();
int myst = rnd.Next(1, 51);
double nbCoups = 0;
double userNbr ;
bool endgame = false;


Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Nombre mystere : " +myst);
Console.ForegroundColor = ConsoleColor.White;
while (!endgame == true)
{

    userNbr = Convert.ToDouble(Console.ReadLine());
    nbCoups++;

    if (userNbr > myst)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus petit");
    }
    else if (userNbr == myst)
    {
        endgame = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo !! Vous avez trouvé le nombre mystrére");
    }
    else if (userNbr < myst)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus grand");
    }

}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Win en " + nbCoups + "coup");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
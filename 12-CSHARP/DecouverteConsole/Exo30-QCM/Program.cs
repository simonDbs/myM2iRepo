
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Question à choix multiple ---");
Console.WriteLine("\nQuelle est l'instruction qui permet de sortir d'une boucle en C# ?");
Console.Write(    "\n\t a) quit"+
                  "\n\t b) continue" +
                  "\n\t c) break" +
                  "\n\t d) EXIT THE GAME"
    );

bool choix = false;
string tryAgain;
//double userChoix;

do
{
    Console.WriteLine("Entrez votre réponse : ");
    //userChoix = Convert.ToDouble(Console.ReadLine());
    choix = Char.TryParse(Console.ReadLine(), out char c);
    if (c == 'a' )
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecte ! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Un nouvel essai ? Oui / Non : ");
        tryAgain = Console.ReadLine();
        if (tryAgain == "oui")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vous avez Continuez ");
            Console.ForegroundColor = ConsoleColor.White;
            continue;
        }else if(tryAgain == "non")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ForegroundColor = ConsoleColor.White;
            choix = true;
           
        }
       
    }
    else if (c == 'b')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecte ! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Un nouvel essai ? Oui / Non : ");
        tryAgain = Console.ReadLine();
        if (tryAgain == "oui")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vous avez Continuez ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (tryAgain == "non")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        }
    }
    else if (c == 'c')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo le Veau ! ");
        Console.ForegroundColor = ConsoleColor.White;
        choix = true;
        break;
        //Console.ForegroundColor = ConsoleColor.White;
        //Console.WriteLine("Un nouvel essai ? Oui / Non : ");
        //tryAgain = Console.ReadLine();
        //if (tryAgain == "oui")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Vous avez Continuez ");
        //}
        //else if (tryAgain == "non")
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("GAME OVER");
        //    break;
        //}
    }
    else if (c == 'd')
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Thx for playing! ");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }

    Console.WriteLine();


} while (!choix == false);

Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
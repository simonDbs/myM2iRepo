Console.WriteLine("--- Le grand tirage au sort ---");




string[] tableauAllreadyPick = new string[11];
Random rnd = new Random();
bool END_PROG = false;
string[] tableau = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juilet", "Août", "Septembre", "Novembre", "Décembre" };

string chaine = "  ";


Console.Clear();
do
{
    
    Console.WriteLine("\n1---Effectuer un tirage" +
                  "\n2---Voir la liste des personnes déja tirées" +
                  "\n3---Voir La liste des personnes restantes" +
                  "\n0---Quitter"
    );
    int userChoiseNbr = Convert.ToInt32(Console.ReadLine());
    switch (userChoiseNbr)
    {
        case 1:
            int Hazard = rnd.Next(1, 13);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n*******************************************\n* L'heureux gagnant est : {tableau[Hazard]} *\n*******************************************"
                );
            Console.ForegroundColor = ConsoleColor.White;
            
            continue;
        case 2:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n*******************************************\n* Liste des personnes déja été tiré : *\n*******************************************"
                );
            Console.ForegroundColor = ConsoleColor.White;
            foreach (string firstName in tableau)
            {
                Console.WriteLine(chaine + firstName);
                chaine += "  ";
            }
            continue; 
            case 0:
            Environment.Exit(0);
            break;
        default:
            break;
    }

} while (!END_PROG == true);




Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
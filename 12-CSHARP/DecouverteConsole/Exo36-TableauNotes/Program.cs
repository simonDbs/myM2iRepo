using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;


double nbNotes = 0;
double maxNote = 0;
double minNote = 20;
double moyNote = 0;
bool ok = false;
double somme = 0;
double noteTmp;
int userChoiseNbr;
int[] TableauNote = new int[0];


bool END_PROG = false;

//Environment.Exit(0);


do
{
    Console.WriteLine("***** Tableaux des notes ******");
    Console.Write("\n\t 1----Saisir les notes" +
                      "\n\t 2----La plus grande note" +
                      "\n\t 3----La plus petite note" +
                      "\n\t 0----Quitter"
        );
    Console.WriteLine("\n\nFaite votre choix : ");
    int choixMenu = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("test");
    switch (choixMenu)
    {
        case int n when n == 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------ Saisir les notes ------");
            Console.ForegroundColor = ConsoleColor.White;
            userChoiseNbr = Convert.ToInt32(Console.ReadLine());
            TableauNote = new int[userChoiseNbr];

            while (!ok)
            {
                Console.Write("\nMerci de saisir la note " + (nbNotes + 1) + " (sur /20) : ");

                for (int i = 0; i < TableauNote.Length; i++)
                {
                    Console.Write("Saisir la notre " + (i + 1) + " : ");
                    TableauNote[i] = Convert.ToInt32(Console.ReadLine());
                }

                
               


            }
            moyNote = Math.Round(((somme / nbNotes)));

            Console.WriteLine(" La moyenne note est " + moyNote + " / 20");
            Console.WriteLine(" La  moins bonne note est " + minNote + " / 20");
            Console.WriteLine(" La meilleur note est " + maxNote + " / 20");
            continue;

        case int n when n == 2:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------ La plus grande note ------");
            Console.WriteLine("\nLa note la plus grande est " + maxNote + " /20");
            Console.ForegroundColor = ConsoleColor.White;
            continue;
        case int n when n == 3:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------ La plus petite note ------");
            Console.WriteLine("\nLa note la plus petite note est " + minNote + " /20");
            Console.ForegroundColor = ConsoleColor.White;
            continue;
        default:
            return;
    }
} while (!END_PROG == true);




Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
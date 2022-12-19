using System;
using System.Collections.Generic;
using System.Data;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(" Gestion des Contacts =======");


bool END_PROG = false;
int userChoiseNbr;
string [] T2 = new string[0];


Console.Clear();
do
{
    
    Console.WriteLine("\n----- Ma liste de contacts -----");
    Console.WriteLine("\n1----- Saisir des contacts" +
                      "\n2----- Afficher mes contacts" +
                      "\n0----- Quitter");
    int choixMenu = Convert.ToInt32(Console.ReadLine());
    switch (choixMenu)
    {
        case  1:
            Console.Clear();
            Console.WriteLine("Merci de saisir le nombre de contact : ");
            userChoiseNbr = Convert.ToInt32(Console.ReadLine());    
             T2 = new string[userChoiseNbr];
            Console.WriteLine(T2);
            switch (userChoiseNbr)
            {
                case int menuAddcontact when menuAddcontact != 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------- Saisir les contacts --------");
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < T2.Length; i++)
                    {                     
                        Console.Write("Nom et Prénom du contact N° " + (i + 1) + " : ");
                        T2[i] = Console.ReadLine();                                                     
                    }
    
                    continue;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veuillez saisir un minimun de 1 en contact");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
            }

        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------- Affichage des contacts --------");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < T2.Length; i++)
            {
                Console.Write("\nNom et Prénom du contact N° " + (i + 1) + " : " + T2[i]);
            }
            break;

        case 0:
            END_PROG = true;
            break;

        default:
            break;
    }

} while (!END_PROG == true);

Environment.Exit(0);


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();

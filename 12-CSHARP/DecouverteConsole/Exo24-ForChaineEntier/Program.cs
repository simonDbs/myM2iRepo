using System;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Les suites de nombres ---");
Console.Write("Merci de saisir un nombre : ");
double nombre = Convert.ToDouble(Console.ReadLine());


double somme;
string chaine;


    for (int i = 1; i <= nombre / 2 + 1; i++)
    {
        somme = i;
        chaine = nombre + " = " + i;
        for (int j = i + 1; j <= nombre / 2 + 1; j++)
        {
            somme += j;
            chaine += "+" + j;
            if (somme == nombre)
            {
            Console.WriteLine(chaine);
                break;
            }
            else if (somme > nombre)
                break;
        }
    }
 


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
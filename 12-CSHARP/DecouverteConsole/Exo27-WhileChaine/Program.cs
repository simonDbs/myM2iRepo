using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Somme entiers chainée ---");

Console.Write("Merci de saisir un nombre : ");
double nombre = Convert.ToDouble(Console.ReadLine());
double i = 1;

double somme;
string chaine;

while ( i <= nombre / 2 + 1)
{
     somme = i;
     chaine = nombre + " = " + i;
    double j = i + 1;
    while (j <= nombre / 2 + 1)
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
        j++;
        }
    i++;
    }


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
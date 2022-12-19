using System;
using System.Drawing;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Gestion des notes ---");
Console.WriteLine("Veuillez saisir 5 notes : ");
//double nbNotes = Convert.ToDouble(Console.ReadLine());


double nbNotes = 5;
double noteMax = 0;
double noteMin =20;
double moyNotes;
double somme = 0;




for (int i = 1; i <= nbNotes; i++)
{

    Console.Write("Note n°: "+ i + " (sur 20) : ");
    double noteTmp = Convert.ToDouble(Console.ReadLine());

    somme += noteTmp;

    if (noteTmp > noteMax)
        noteMax = noteTmp;
   
    if (noteTmp < noteMin)
        noteMin = noteTmp;

    moyNotes = Math.Round(noteTmp / nbNotes);
}




//moyNotes = Math.Round(((moyNotes / nbNotes) + Number.EPSILON) * 100) / 100;


Console.WriteLine(" La moins bonne note est " +noteMin+ " / 20");
Console.WriteLine(" La meilleur note est " +noteMin+" / 20");
Console.WriteLine(" La moyenne note est " +noteMin+" / 20");


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Gestion des notes ---");

Console.Write("Veullez saisir les notes : ");

double nbNotes = 0;
double maxNote = 0;
double minNote = 20;
double moyNote = 0;
bool ok = false;
double somme = 0;

double noteTmp;


while (!ok)
{
    Console.WriteLine("Merci de saisir la note " + (nbNotes + 1) + " (sur 20):");
    noteTmp = Convert.ToDouble(Console.ReadLine());


    if (!Double.IsNaN(noteTmp))
    {
        if (noteTmp >= 0 && noteTmp <= 20)
        {


            Console.WriteLine("En note " + (nbNotes + 1) + " , vous avez saisi " + noteTmp + " / 20:");

            moyNote += noteTmp;

            if (noteTmp > maxNote)
                maxNote = noteTmp;


            if (noteTmp < minNote)
                minNote = noteTmp;
            nbNotes++;
            somme += noteTmp;
        }

        else if (noteTmp == 666)
            ok = true;
        else
            Console.WriteLine("Merci de saisir une note entre 0 et 20:");

    }
    else
        Console.WriteLine("Merci de saisir un nombre...");


}

moyNote = Math.Round(((somme / nbNotes)));

Console.WriteLine(" La moyenne note est " + moyNote + " / 20");
Console.WriteLine(" La  moins bonne note est " + minNote + " / 20");
Console.WriteLine(" La meilleur note est " + maxNote + " / 20");




Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
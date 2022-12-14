using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteConsole
{
    public class Start
    {
        public static void Main(string[] args)
        {
            #region Affichage dans la console
            Console.Write("Je m'affiche ...");
            Console.Write("Sans retour a la ligne");
            Console.WriteLine("J'ai un retour a la ligne..");
            Console.WriteLine("la preuve");
            #endregion

            #region lecture saisie utilisateur
            //Affiche un message au user 
            Console.Write("SAISIR UNE CHAINE DE CHARACTER : ");
            //// Lire un caractere dans la console => Console.Read()
            //char @char = (char)Console.Read();
            ////Affiche le contenu de ma variable @char
            //Console.WriteLine(@char);


            //Lire un chaine de character depuis le flux clavier
            //string maChaine = Console.ReadLine();
            //////Affiche le contenu de ma variable @char
            //Console.WriteLine("saisir une autre chaine 1");
            //string maChaine1 =  Console.ReadLine();
            //Console.WriteLine("saisir une autre chaine 2");
            //string maChaine2 = Console.ReadLine();
            //Console.WriteLine("saisir une autre chaine 3");
            //string maChaine3 = Console.ReadLine();
            //Console.WriteLine(maChaine);
            //Console.WriteLine("Je format ma chaine avec [0] et avec {1} et avec {2}", maChaine, maChaine1, maChaine2, maChaine3);
            #endregion

            #region Changement de colo
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("je suis green");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("je suis rouge");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("je suis gris");
            
            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("Background Green");
            Console.BackgroundColor = ConsoleColor.Black;
            #endregion

            #region Les character spec
            Console.WriteLine("\nLes character spec\n");
            //Afficher un chemin d'acces dans la console
            Console.WriteLine("c:\\repertoire\\MonFichier.cs");
            Console.WriteLine(@"c:\\repertoire\\MonFichier.cs");

            // Le \ devant les "
            Console.WriteLine("HELLO my name is \"Bond\"");

            // Mise en forme du texte avec \n et \t
            Console.WriteLine("Je saute une ligne apres\n");
            Console.WriteLine("Preuve");

            Console.WriteLine("liste des choses a faire");
            Console.WriteLine("\tApprendre le C#");
            Console.WriteLine("\tcree des projets perso");
            Console.WriteLine("\tET PLEIN DE TRUCS");

            Console.OutputEncoding  = Encoding.UTF8;
            Console.WriteLine("€uro\n\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ^ ^\r\n(O,O)\r\n(   )\r\n-\"-\"---dwb-");
            Console.ForegroundColor = ConsoleColor.White;

            #endregion

            #region Afficher date et heure
            DateTime date = DateTime.Now;
            Console.WriteLine("Date et Heure : {0:d} et {0:t}", date);
            #endregion

            Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
            Console.Read();
        }
    }
}

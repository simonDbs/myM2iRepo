using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TpListCompteBancaire.IHM
{
    internal class IHM
    {

        public void Start()
        {
            Console.WriteLine("test");
            string choix = "";

            do
            {
                bool valid = false;
                Menu();
                Console.Write("Entrez votre choix : ");
                choix = Console.ReadLine();
                while (!valid)
                {
                    if (choix != "1" && choix != "2" && choix != "3" && choix != "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Erreur de saisie, entrez votre choix : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        choix = Console.ReadLine();
                    }
                    else
                        valid = true;
                }
                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        // action de creation d'un habitat
                        MenuCreationHabitat();
                        break;
                    case "2":
                        Console.Clear();
                        // action de display la liste des Maison/app
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
            } while (choix != "0");

        }
        private static void Menu()
        {
            Console.WriteLine("===== Banque =====");
            Console.WriteLine("1- Créer un compte bancaire");
            Console.WriteLine("2- Effectuer un dépôt");
            Console.WriteLine("3- Effectuer un retrait");
            Console.WriteLine("4- Opérations et solde");
            Console.WriteLine("5- Calcule Interet");
            Console.WriteLine("0-- Quitter\n");
        }
    }
}

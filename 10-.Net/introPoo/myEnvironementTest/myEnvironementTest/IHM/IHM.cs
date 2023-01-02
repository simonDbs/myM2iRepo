using MyEnvironement.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.IHM
{
    internal class IHM
    {

        private Location[] habitats;
        private int maxHabitats = 20;

        public IHM()
        {
            habitats = new Location[maxHabitats];
        }

        public void Start()
        {   

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
            Console.WriteLine("===== Gestion des habitations =====");
            Console.WriteLine("1- Ajouter un habitat");
            Console.WriteLine("2- Afficher la liste des habitations");
            Console.WriteLine("0-- Quitter\n");
        }

        private void MenuCreationHabitat()
        {
            Console.WriteLine("===== Ajouter une habitations =====");
            Console.WriteLine("1- Ajouter une maison");
            Console.WriteLine("2- Ajouter un appartement\n");
            Console.WriteLine("0-- Retour\n");
        }

        private void ActionCreationHabitat()
        {
            bool valid = false;
            MenuCreationHabitat();
            Console.Write("Entrez votre choix : ");
            string choix = Console.ReadLine();
            while (!valid)
            {
                if (choix != "1" && choix != "2" && choix != "0")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Erreur de saisie, entrez votre choix : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    choix = Console.ReadLine();
                }
                else
                    valid = true;
            }
          
            Location s = null;

            switch (choix)
            {
                case "1":
                    //s = ActionCreationMaison();
                    break;
                case "2":
                    //s = ActionCreationAppartement();
                    break;
                case "0":
                    break;
            }

            if (s != null)
            {
                for (int i = 0; i < habitats.Length; i++)
                {
                    if (habitats[i] == null)
                    {
                        habitats[i] = s;
                        break;
                    }
                }
            }

            Console.Clear();
        }

        private House ActionCreationMaison()
        {
            Console.Write("Merci de saisir le nom : ");
            string roadName = Console.ReadLine();
            Console.Write("Merci de saisir le code postal : ");
            string zipCode = Console.ReadLine();
            Console.Write("Merci de saisir la ville : ");
            string city = Console.ReadLine();
            Console.Write("Merci de saisir le pays : ");
            string country = Console.ReadLine();

            return new House(roadName, zipCode);
        }


       
    }
}

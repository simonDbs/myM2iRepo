using System;

    namespace LesFonctions.CLasses
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region sans params et sans retour
            AffichageBienvennue();
            AffichageBienvennue();
            #endregion


            #region Fonction sans params et avec retour (int)
            Console.WriteLine(AffichageChiffre());
            Console.WriteLine(AffichageMessage());
            #endregion

            #region Fonction avec params et avec Retour
            Console.WriteLine(Additionner(30,8));
            #endregion

            #region Fonction avec params mais ans retour
             AffichageBienvennue("toto","C#");

            #endregion

            Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
            Console.Read();
        }

        static void AffichageBienvennue()
        {
            Console.WriteLine("Hello welcome");
           
        }

        static int AffichageChiffre()
        {
            int chiffre = 10;
            return chiffre;

        }
        static string AffichageMessage()
        {
            string chaine = "Salut";
            return chaine;
          
        }

        static double Additionner(double nb1, double nb2)
        {
            double result = nb1 + nb2;
            return result;

        }

        static void AffichageBienvennue(string prenom , string language)
        {
            Console.WriteLine($"Hi {prenom} vous apprenez le {language}");

        }
    }

 
}



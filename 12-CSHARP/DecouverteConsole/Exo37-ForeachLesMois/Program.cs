


string[] TableauMois = { "Janvier", "Février", "Mars","Avril" ,"Mai","Juin","Juilet","Août","Septembre","Novembre","Décembre"};


foreach (string mois in TableauMois)
{
    string chaine = mois; 
    Console.WriteLine("\t" +chaine);
}



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
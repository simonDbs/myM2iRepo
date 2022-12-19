
#region SwitchCase Simple avec String en condition

string civilite = "Mr";
//string civilite = "Mr";
//string civilite = "Mr";

switch (civilite)
{
    case "Mr":
        Console.WriteLine("Bonjour Monsieur");
        break;
    case "Mme":
        Console.WriteLine("Bonjour Madame");
        break;
    case "Mlle":
        Console.WriteLine("Bonjour Mademoiselle");
        break;
    default:
        Console.WriteLine("Bonjour Undefined");
        break;

}

#endregion



#region SwitchCase Simple avec int en condition


int choix = 5;

switch (choix)
{
    case 1:
        Console.WriteLine("Choix 1");
        break;
    case 2:
        Console.WriteLine("Choix 2");
        break;
    case 3:
        Console.WriteLine("Choix 3");
        break;
    default:
        Console.WriteLine("Choix inconnue");
        break;

}
#endregion




#region SwitchCase avec comparaisson de valeur int



double compte = 300;

switch (compte)
{
    case double n when n  > 0:
        Console.WriteLine("Votre compte est créditeur");
        break;
    case double n when n == 0:
        Console.WriteLine("Votre compte est nul ");
        break;
    //case double n when n < 0:
    //    Console.WriteLine("Votre compte est débiteur");
    //    break;
    default:
        Console.WriteLine("Votre compte est débiteur");
        break;
}

#endregion



#region Switch avec comparraison et range de valeur



double age = 10;

switch (age)
{
    case double n when n > 0 && n <= 12:
        Console.WriteLine("Vous etes mineur");
        break;
    case double n when n > 12 && n < 18:
        Console.WriteLine("Vous etes adolecent ");
        break;
    case double n when n >= 18:
        Console.WriteLine("Vous etes adultes");
       break;
    default:
        Console.WriteLine("WTF");
        break;
}
#endregion
Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
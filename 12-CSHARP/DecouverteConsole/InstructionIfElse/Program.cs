/// Utilisisation du charset UTF8

Console.OutputEncoding = System.Text.Encoding.UTF8;


// Structure if avec une seul condition
Console.Write("Veuillez saisir le montant du compte en banque : ");
//Recuperation de la valeur du compte
double compteEnBanque = Convert.ToDouble(Console.ReadLine());


#region if else
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur..");


if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte en banque est créditeur..");
    Console.WriteLine($"Solde restant : {compteEnBanque} €");
}

//Plusieur verif 
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur..");
if (compteEnBanque == 0)
    Console.WriteLine("Votre compte est nul");
if (compteEnBanque < 0)
    Console.WriteLine("Votre compte est debiteur");


//Plusieur verif avec cas par defaut
if (compteEnBanque > 0)
    Console.WriteLine("Votre compte en banque est créditeur..");
if (compteEnBanque == 0)
    Console.WriteLine("Votre compte est nul");
else
    Console.WriteLine("Votre compte est debiteur");

//Plusieur verif 'bloucle imbriquer)
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte en banque est créditeur..");
}
else
if (compteEnBanque == 0)
{
    Console.WriteLine("Votre compte est nul");
}
else
{
    Console.WriteLine("Votre compte est debiteur");
}

#endregion


#region if else ifelse
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte est crediteur");
    Console.WriteLine($"solde restant {compteEnBanque} €");
}
else if (compteEnBanque == 0)
{
    Console.WriteLine("Votre compte est nul");
    Console.WriteLine($"solde restant {compteEnBanque} €");
}
else 
{
    Console.WriteLine("Votre compte est debiteur");
    Console.WriteLine($"solde restant {compteEnBanque} €");
}
#endregion

Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
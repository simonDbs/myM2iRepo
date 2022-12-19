using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? ---");
Console.WriteLine("Veuillez saisir le dernier salaire (en €uro)  : ");
double salaire = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir l'age du salarié  : ");
double age = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Veuillez saisir l'ancienneté  : ");
double anciennete = Convert.ToDouble(Console.ReadLine());

double indemnite = 0;

if (anciennete >= 1 && anciennete <= 10)
{
    indemnite += anciennete * salaire / 2;
}
if (anciennete > 10)
{
    indemnite += 10 * salaire / 2;
    indemnite += (anciennete - 10) * salaire;
}

if (anciennete >= 1 && age > 45)
{

    if (age < 50)
        indemnite += 2 * salaire;
    else
        indemnite += 5 * salaire;

}
Console.WriteLine($"Votre indemnité est de : {indemnite} €");



Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
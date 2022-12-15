

#region Les chaine de caractères
// Les chaine sont de type string
//Déclaration d'une variables string
using System.Runtime.CompilerServices;

//string prenom;
////Affectation de valeur à la variable string
//prenom = "Jacque";

//Console.WriteLine(prenom);

//string nom = "Chirac";
////Affectation de valeur a nom2 avec la valeur de nom (valeur et non ref)
//string nom2 = nom;

//Console.WriteLine(nom == nom2);
//Console.WriteLine("Veuillez saisir une valeur pour nom2");
//nom2 = Console.ReadLine(); 

//Console.WriteLine(nom == nom2);

//Console.WriteLine("Nom complet est {0} {1}", prenom,nom);
//Console.WriteLine($"Nom complet est {prenom} { nom} ");
//Console.WriteLine(prenom[0]);
#endregion

#region Les variables numerique
//Declarationd de variable int
int age;
//affectation de valeur int
age = 9999;
Console.WriteLine($"age est de:  { age}");



#endregion



#region var de type object
object monObjet;
monObjet = "Ma chaine Objet";
Console.WriteLine(monObjet);
#endregion

//Console.WriteLine(" _._     _,-'\"\"`-._\r\n(,-.`._,'(       |\\`-/|\r\n    `-.-' \\ )-`( , o o)\r\n          `-    \\`_`\"'-");
Console.WriteLine("Push button to shutdown");
Console.Read();
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Les Tables de multiplication ---");



for (var i = 1; i <= 10; i++)
{
    //C'est pas en forme .. mais bon hein
    Console.WriteLine("Table de :" + i );

for (var j = 1; j <= 10; j++)
{

Console.WriteLine( i + "x" + j + "=" + (i*j));
  }
 
}


Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
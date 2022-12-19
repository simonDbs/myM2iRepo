using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("--- Quelle boisson vais-je prendre? ---");
Console.WriteLine("*****DISTRIBUTEUR DE BOISSON * **** " +
               "\n 1) Eau " +
               "\n 2) Jus d'oranges" +
               "\n 3) Limonade" +
               "\n 4) Café" +
               "\n 5) Thé" +
               "\n Faites votre choix : ");

double choix = Convert.ToDouble(Console.ReadLine());


switch (choix)

{
  
    case 1:
        Console.WriteLine($" Votre Eau est servie... `");
        break;
    case 2:
        Console.WriteLine($" Votre Jus d'orange est servie... `");
        break;
    case 3:
        Console.WriteLine($" Votre Limonade est servie... `");
        break;
    case 4:
        Console.WriteLine($" Votre Café est servie... `");
        break;
    case 5:
        Console.WriteLine($" Votre Thé est servie... `");
        break;
    default:
  
        break;
}







Console.WriteLine("\n\nappuyez sur un bouton pour fermer la console");
Console.Read();
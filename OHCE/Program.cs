//Etape 1
using OHCE;

Console.WriteLine("Etape 1 - entrez une phrase : ");
string maPhrase = Console.ReadLine();
Console.WriteLine(MethodsUtility.Palyndrome(maPhrase));

//Etape 2
Console.WriteLine("\nEtape 2 - entrez la langue : français / english");
string lang = Console.ReadLine();
Console.WriteLine("\nEntrez une phrase : ");
maPhrase = Console.ReadLine();
Console.WriteLine(MethodsUtility.PalyndromeLang(maPhrase, lang));

//Etape 3
Console.WriteLine("\nEtape 3 - auto");
Console.WriteLine("\nEntrez une phrase : ");
maPhrase = Console.ReadLine();
Console.WriteLine(MethodsUtility.PalyndromePart3(maPhrase));
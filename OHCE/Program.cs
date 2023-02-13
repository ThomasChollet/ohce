//Etape 1
using OHCE;
using static OHCE.MethodsUtility;

public class Program
{
    public string Lg { get; set; }
    public PartOfDay PDay { get; set; }
    
    public Program() {
    }

    public Program(string lg, PartOfDay pDay)
    {
        this.Lg= lg;
        this.PDay= pDay;
        
    }

    public static void Main(string[] args)
    {
        Program pgm = new Program();
        pgm.Method();
        Console.WriteLine("\n\nPROGRAMME AVEC ARGS AUTO :\n\n");
        Program pgmWithArgs = new Program("français", PartOfDay.ApresMidi);
        pgmWithArgs.MethWithArgs();
    }

    public void Method()
    {
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
        Console.WriteLine(MethodsUtility.PalyndromePart3(maPhrase, PartOfDay.Null));
    }

    public void MethWithArgs()
    {
        string maPhrase;
        //Etape 2
        Console.WriteLine("\nEtape 2 avec args- ");
        Console.WriteLine("\nEntrez une phrase : ");
        maPhrase = Console.ReadLine();
        Console.WriteLine(MethodsUtility.PalyndromeLang(maPhrase, Lg));

        //Etape 3
        Console.WriteLine("\nEtape 3 - auto");
        Console.WriteLine("\nEntrez une phrase : ");
        maPhrase = Console.ReadLine();
        Console.WriteLine(MethodsUtility.PalyndromePart3(maPhrase, PDay));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public static class MethodsUtility
    {

        public enum Languages { Francais, English, Unknown }

        public static string Palyndrome(String phrase)
        {
            if (phrase.Equals("")) return null;

            string reversedString = ReverseString(phrase);

            StringBuilder stringB = new StringBuilder();
            stringB.Append("\nBonjour !\n");

            if (phrase == reversedString && !phrase.Equals(""))
            {
                stringB.Append(phrase);
                stringB.Append("\nBien joué !");
            }
            else
            {
                stringB.Append(reversedString);
            }

            stringB.Append("\nAu revoir !");
            return stringB.ToString();
        }

        public static string PalyndromeLang(String phrase, String langue)
        {
            StringBuilder stringB = new StringBuilder();
            Languages lang = Language(langue);

            if (lang == Languages.Unknown) return "Langage inconnu ! Retour à l'étape 1\n\n" + Palyndrome(phrase);
            else if (lang == Languages.Francais) stringB.Append("\nBonjour !\n");
            else stringB.Append("\nHello !\n");


            if (phrase == ReverseString(phrase) && !phrase.Equals(""))
            {
                stringB.Append(phrase);
                if (lang == Languages.Francais) stringB.Append("\nBien joué !");
                else stringB.Append("\nWell done !");
            }
            else
            {
                stringB.Append(ReverseString(phrase));
            }

            if (lang == Languages.Francais) stringB.Append("\nAu revoir!\n");
            else stringB.Append("\nGoodbye !\n");

            return stringB.ToString() ;

        }

        public static string ReverseString(String phrase)
        {
            string reversedString;
            char[] stringArray = phrase.ToCharArray();
            Array.Reverse(stringArray);
            return reversedString = new string(stringArray);
        }

        public static Languages Language(String lang)
        {
            if (lang.Equals("francais", StringComparison.InvariantCultureIgnoreCase) || lang.Equals("français", StringComparison.InvariantCultureIgnoreCase)) return Languages.Francais;
            else if (lang.Equals("anglais", StringComparison.InvariantCultureIgnoreCase) || lang.Equals("english", StringComparison.InvariantCultureIgnoreCase)) return Languages.English;
            else return Languages.Unknown;
        }

    }
}

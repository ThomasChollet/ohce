using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public static class MethodsUtility
    {

        public static string Palyndrome(String phrase)
        {
            if (phrase.Equals("")) return null;

            char[] stringArray = phrase.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);

            StringBuilder stringB = new StringBuilder();
            stringB.Append("\nBonjour !\n");

            if (phrase == reversedString && !phrase.Equals(""))
            {
                stringB.Append(phrase);
                stringB.Append("\nBien joué !\n");
            }
            else
            {
                stringB.Append(reversedString);
            }

            stringB.Append("Au revoir !");
            return stringB.ToString();
        }

    }
}

using System;
using System.Linq;

namespace IsStringIsogram
{
    class Program
    {

        // Given a string S of lowercase alphabets, check if it is isogram or not.
        // An Isogram is a string in which no letter occurs more than once.

        public static void IsIsogram()
        {
            bool results = false;
            int ogCount = 0;

            //string originalString = "cat"; //"amanisaman";
            string originalString = "amanisaman";

            ogCount = originalString.Length;
            string newString = new string(originalString.ToCharArray().Distinct().ToArray());

            if(ogCount == newString.Length)
            {
                results = true;   
            }

            Console.WriteLine(string.Format("Is the string a Isogarm: {0}", results));

        }
        static void Main(string[] args)
        {
            IsIsogram();
        }
    }
}

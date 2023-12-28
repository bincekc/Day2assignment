using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHnadling
{
    internal class StringFunction
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";

            // a) Print the character at the 12th index.

            Console.WriteLine($"a) The character at the 12th index of the string is {str[12]}");

            //b) Check whether the String contains the word “is”.

            Console.WriteLine($"b) The string contains the word 'is':  {str.Contains("is")}");

            // c)Add the string “and killed it” to the existing string.

            string newstring = str + " " + "and killed it";
            Console.WriteLine($"c) New string is: {newstring}");

            // d) Check whether the String ends with the word “dogs”.
            Console.WriteLine($"d) Ends with 'dogs': {str.EndsWith("dogs")}");


            //e) Check whether the String is equal to “The quick brown Fox jumps over the lazy Dog”.
            string str1 = "The quick brown Fox jumps over the lazy Dog";

            if (str.Equals(str1))
            {
                Console.WriteLine("e) Strings are Equal");
            }
            else
            {
                Console.WriteLine("e) Strings are not Equal");
            }


            //f) Check whether the String is equal to “THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG”.

            string str2 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            if (str.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("f) Strings are Equal");
            }
            else
            {
                Console.WriteLine("f) Srings are not Equal");
            }

            //g)Find the length of the String.

            Console.WriteLine($"g) Length of the string is: {str.Length}");

            //h)Check whether the String matches to “The quick brown Fox jumps over the lazy Dog”.
            string str3 = "The quick brown Fox jumps over the lazy Dog";

            if (str.Equals(str3))
            {
                Console.WriteLine("h) Strings are Matching");
            }
            else
            {
                Console.WriteLine("h) Strings are not Matching");
            }

            // i)Replace the word “The” with the word “A”.
            Console.WriteLine($"i) Sting after replacement is: {str.Replace("The", "A")}");

            //j)Split the above string into two such that two animal names do not come together.

            string sent = "The quick brown fox  jumps over the lazy dog";

            string[] str5 = sent.Split("  ");
            foreach (string s in str5)
                Console.WriteLine($"j) The sentence is splitted as: {s}");



            // k)Print the animal names alone separately from the above string.
            string[] animalNames = { "fox", "dog" };
            foreach (string animal in animalNames)
            {
                Console.WriteLine($"k) Animal: {animal}");
            }

            //l)Print the above string in completely lower case.
            string lowerCaseString = str.ToLower();
            Console.WriteLine($"l) Lower case string: {lowerCaseString}");

            //m)Print the above string in completely upper case.

            string upperCaseString = str.ToUpper();
            Console.WriteLine($"m) Upper case string: {upperCaseString}");

            //n)Find the index position of the character “a”.

            int indexOfA = str.IndexOf('a');
            Console.WriteLine($"n) Index of 'a' is: {indexOfA}");

            //o)Find the last index position of the character “e”.

            int lastIndexOfE = str.LastIndexOf('e');
            Console.WriteLine($"o) Last index of 'e': {lastIndexOfE}");

            // p)Prompt the user to enter the home directory of Tomcat server.To the path that user enters, add another path to WebApps/ MyApps / Images  directory and display it in the console. Use verbatim string literals.
            Console.WriteLine("p) Enter the home directory of Tomcat server:");
            string tomcatserver = Console.ReadLine();
            string updatedpath = $@"{tomcatserver}/WebApps/MyApps/Images";
            Console.WriteLine($"UpdatedPath: {updatedpath}");

            //q)Write a C# code that has a constant string that represents poem lines

            const string poemLine = @"I WANDER'D lonely as a cloud
                                        That floats on high o'er vales and hills,
                                        When all at once I saw a crowd,
                                        A host, of golden daffodils;Beside the lake, beneath the trees,
                                        Fluttering and dancing in the breeze.";
                                             Console.WriteLine($"q) Poem line:\n{poemLine}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the Disemvoweler function
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine();
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears");
            Console.WriteLine();
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }

        //making the Disemvoweler function
        static void Disemvoweler(string input)
        {
            //making my variables and parameters to search through
            string consonants = "";
            string vowels = "";
            string consonantsLookingFor = "bcdfghjklmnpqrstvwxyz";
            consonantsLookingFor += consonantsLookingFor.ToUpper();
            string vowelsLookingFor = "aeiou";
            vowelsLookingFor += vowelsLookingFor.ToUpper();

            //looping through the string input checking for vowels and consonants
            for (int i = 0; i < input.Length; i++)
			{
			 if (vowelsLookingFor.Contains (input[i]))
                {
                 //there is a vowel   
                 vowels += input[i];
                }
             if (consonantsLookingFor.Contains (input[i])) 
                {
                 //there is a consonant   
                 consonants += input[i];
                }
			}
            //writing the vowels removed to the console
            Console.WriteLine(consonants);
            Console.WriteLine("Vowels Removed: " + vowels);
        }
    }
}

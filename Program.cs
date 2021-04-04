// C# program for the naive approach
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 In the programming language of your choice, write a program that parses a sentence and replaces each word with the following:
 first letter, number of distinct characters between first and last character, and last letter.
 For example, Smooth would become S3h.
 Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer.

*/


class Program
{
    static void Main(string[] args)
    {
        string phrase = "Something out of This world that is smOoth";
        string[] words = phrase.Split(' ');

        string newsentence = null;
        int count = 0;

        foreach (string word in words)
        {
            int distinctCount = 0;

            string firstChar = word.Substring(0, 1);
            string lastChar = word.Substring(word.Length - 1, 1);

            if (word.Length > 2)
            {
                string middlechars = word.Substring(1, word.Length - 2);
                string mid_chars = middlechars.ToLower();
                distinctCount = mid_chars.Distinct().Count();
            }

            if (count == 0)
            {
                count++;
            }
            else
            {
                newsentence += " ";  //only concatenate space after first word
            }

            newsentence += String.Concat(firstChar, distinctCount.ToString(), lastChar);

        }
        Console.Write(newsentence);

        Console.ReadKey();

    }
}


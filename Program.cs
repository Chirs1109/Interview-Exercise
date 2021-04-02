﻿// C# program for the naive approach
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
    public void TheCountOfDistinctChars(string[] args)
    {

    }
    static void Main(string[] args)
    {
        string phrase = "I want something out of This world";
        string[] words = phrase.Split(' ');

        //Keep this code for testing
        //string[] strArr = new[] { "Something", "out", "of", "This", "world" };
        //List<string> newsentence = new List<string>();
        StringBuilder builder = new StringBuilder();
        foreach (string word in words)

          //  foreach (string word in words)

        {
           
            string newword = null;
            if (word.Length > 2)
            {
                int distinctCount = 0;
                int k = word.Length;
                int samecharcount = 0;
                int count = 0;

                for (int i = 1; i < k - 2; i++)
                {

                    if (word.ElementAt(i) != word.ElementAt(i + 1))
                    {

                        count++;

                    }
                    else
                    {
                        samecharcount++;

                    }
                }
                distinctCount = count + samecharcount;

                char firstChar = word[0];
                char lastChar = word[word.Length - 1];
                newword = String.Concat(firstChar, distinctCount.ToString(), lastChar);
                 Console.Write(newword + " ");
            }

            else
            {

                Console.Write(builder.Append(word).Append(" "));
            }

        }
        Console.ReadKey();
    }
}
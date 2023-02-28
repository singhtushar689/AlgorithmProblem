﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Anagram
    {
        public void CheckAnagram(string input1,string input2)
        {
            char[] char1 = input1.ToLower().ToCharArray();
            char[] char2 = input2.ToLower().ToCharArray();

            Array.Sort(char1, char2);

            string str1 = char1.ToString();
            string str2 = char2.ToString();

            if (str1 == str2)
                Console.WriteLine("The Input is Anagram");
            else
                Console.WriteLine("Not A Anagram");

        }
    }
}

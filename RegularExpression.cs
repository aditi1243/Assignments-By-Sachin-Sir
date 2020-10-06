﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpf
{
    class Program
    {
        static void Main(string[] args)
        { //for \d

            //Apply RegEx and find for match value=99,value=55

            //step 1:Create a RegEx--object need to be created.

            Regex exp = new Regex(@"\d+");//Find the digits present/match in the string

            //step 2:call the match on the RegEx instance

            Match Match = exp.Match("Aishu77Aishu");

            ////step 3:Test the Validation/success
            if (Match.Success)
            {
                Console.WriteLine("The match value of the digit is:" + Match.Value);
            }


            //for \b

            //step 1:Create a RegEx--object need to be created.

            Regex exp1 = new Regex(@"Rani\b");

            //step 2:call the match on the RegEx instance

            Match Match1 = exp1.Match("Aishu Rani Sonu");

            ////step 3:Test the Validation/success
            if (Match1.Success)
            {
                Console.WriteLine("Middle value is:{0}", Match1.Value);
            }


            //for \B

            //step 1:Create a RegEx--object need to be created.

            Regex exp2 = new Regex(@"\BKishan");

            //step 2:call the match on the RegEx instance

            Match Match2 = exp2.Match("Raju Kishan Kiran");

            ////step 3:Test the Validation/success
            if (Match2.Success)
            {
                Console.WriteLine("Middle value is:{0}", Match2.Value);
            }


            //for \D

            //step 1:Create a RegEx--object need to be created.

            Regex exp3 = new Regex(@"\D+");

            //step 2:call the match on the RegEx instance

            Match Match3 = exp3.Match("Raju Kishan99Kiran");

            ////step 3:Test the Validation/success
            if (Match3.Success)
            {
                Console.WriteLine(Match3.Value);
            }

            //for \s

            //step 1:Create a RegEx--object need to be created.

            Regex exp4 = new Regex(@"\s+");

            //step 2:call the match on the RegEx instance

            Match Match4 = exp4.Match("Raju Kishan  99Kiran");

            ////step 3:Test the Validation/success
            if (Match4.Success)
            {
                Console.WriteLine(Match4.Value);
            }

            //for \S

            //step 1:Create a RegEx--object need to be created.

            Regex exp5 = new Regex(@"\S+");

            //step 2:call the match on the RegEx instance

            Match Match5 = exp5.Match("RajuKishanKiran");

            ////step 3:Test the Validation/success
            if (Match5.Success)
            {
                Console.WriteLine(Match5.Value);
            }


            //for \w

            //step 1:Create a RegEx--object need to be created.

            Regex exp6 = new Regex(@"\w+");

            //step 2:call the match on the RegEx instance

            Match Match6 = exp6.Match("Raju0999#$__Aishu45");

            ////step 3:Test the Validation/success
            if (Match6.Success)
            {
                Console.WriteLine(Match6.Value);
            }


            //for \W

            //step 1:Create a RegEx--object need to be created.

            Regex exp7 = new Regex(@"\W+");

            //step 2:call the match on the RegEx instance

            Match Match7 = exp7.Match("HDEHFW00998");

            ////step 3:Test the Validation/success
            if (Match7.Success)
            {
                Console.WriteLine(Match7.Value);
            }


            //for \z

            //step 1:Create a RegEx--object need to be created.

            Regex exp8 = new Regex(@"\z");

            //step 2:call the match on the RegEx instance

            Match Match8 = exp8.Match("Raju Kishan99 Kiran");

            ////step 3:Test the Validation/success
            if (Match8.Success)
            {
                Console.WriteLine(Match8.Value);
            }



            // //for \A

            Regex exp9 = new Regex(@"\A+");

            string a = "Aishwarya Jadhav";
            string g = "Aishwarya";

            if (g.Equals(a))
            {
                Console.WriteLine("String Matched");
            }
            else
            {
                Console.WriteLine("String Not Matched");
            }


            string test = "aabb";
            //match the start of a string
            if (Regex.IsMatch(test, "$bb"))
            {
                Console.WriteLine("Pattern Matched where string is Staring with:");
            }

            //NextMatch()
            string value = "10 and 20 ";
            //step 1:get the first Match
            Match mch = Regex.Match(value, @"\d+");
            if (mch.Success)
            {

                Console.WriteLine("Pattern matches and digits are:" + mch.Value);

            }

            //step 2:Get Second match
            mch = mch.NextMatch();
            if (mch.Success)
            {
                Console.WriteLine("The Second Excuted and the digits are:" + mch.Value);
            }



            //Replace()
            Regex regex = new Regex(@"\d+");
            string str = regex.Replace("dog 456 123", "bird");
            Console.WriteLine(str);




            Console.ReadLine();
        }
    }
}
        }
    }
}

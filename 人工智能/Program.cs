﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AI.Properties;
using System.Text.RegularExpressions;

namespace 人工智能
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strtext = new List<string>();
            string[] sr = File.ReadAllLines(@"../../wenben/tempFile.txt");
            string text = "";
            foreach (string s in sr)
            {
                text += s;
            }
            string[] strArr = Regex.Split(text, "人工智能", RegexOptions.IgnoreCase);
            foreach (var s in strArr)
            {
                strtext.Add(s);
            }
            foreach (var s in strtext)
            {
                string c = "人工智能" + s + "\n";
                int i = 1;
                foreach (char r in c)
                {
                    Console.Write(r);
                    i++;
                    if (i == 13)
                    {
                        Console.WriteLine("...");
                        break;
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the gradebook project");
            //Console.BackgroundColor();

            // SpeechSynthesizer synth = new SpeechSynthesizer();
            // synth.Speak("Welcome to the gradebook project!");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
        }
    }
}

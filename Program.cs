using System;
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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n-------------------Welcome to the gradebook project-----------------------\n");


            // SpeechSynthesizer synth = new SpeechSynthesizer();
            // synth.Speak("Welcome to the gradebook project!");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Here's the averages for your grades: ");
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Here's the highest grade: ");
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Here's the lowest grade: ");
            Console.WriteLine(stats.LowestGrade);
        }
    }
}

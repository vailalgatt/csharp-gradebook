using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades.Gradebook;

namespace Grades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Gradebook.Grades gradebook = new GradeBook.Grades();
            gradebook.Running = true;

            gradebook.Setup();
            gradebook.BuildGrades();
            System.Console.WriteLine($"{gradebook.CurrentStudent.Name}:\n{gradebook.CurrentStudent.Description}");


            while (gradebook.Playing)
            {

                string userChoice = gradebook.GetUserInput().ToLower();
                string[] userAction = userChoice.Split(' ');
                Student nextStudent;
                gradebook.CurrentStudent.Exits.TryGetValue(userAction[0], out nextStudent);

                if (userAction[0] == "l" || userAction[0] == "look")
                {
                    System.Console.WriteLine("\n");
                    gradebook.Look(gradebook.CurrentStudent);
                }
                else if (userAction[0] == "h" || userAction[0] == "help")
                {
                    gradebook.Help();
                }
                else if (userAction[0] == "g" || userAction[0] == "give")
                {
                    gradebook.Give(userAction[1]);
                }
                else if (userAction[0] == "i" || userAction[0] == "gradebook")
                {
                    System.Console.WriteLine("Gradebook");
                    gradebook.CurrentPlayer.ShowGradebook(gradebook.CurrentPlayer);
                }
                else if (userAction[0] == "q" || userAction[0] == "quit")
                {
                    gradebook.Playing = gradebook.Quit(gradebook.Playing);
                }
                else if (nextStudent != null)
                {
                    gradebook.CurrentStudent = nextStudent;
                    System.Console.WriteLine("\n");
                    gradebook.CurrentPlayer.Score += 2;
                    gradebook.Look(gradebook.CurrentStudent);
                }
                else
                {
                    System.Console.WriteLine("Invalid input type. Try Again!\n");
                }
            }


            //             Console.Clear();
            //             Console.ForegroundColor = ConsoleColor.Yellow;
            //             Console.WriteLine("\n-------------------Welcome to the gradebook project-----------------------------\n");


            //             GradeBook book = new GradeBook();
            //             book.AddGrade(91);
            //             book.AddGrade(89.5f);
            //             book.AddGrade(75);
            //             book.AddGrade(60);
            //             book.AddGrade(85);
            //             book.AddGrade(95);
            //             book.AddGrade(54);

            //             string userChoice = book.UserInput().ToLower();
            //             string[] userAction = userChoice.Split(' ');
            // //will add some options to this area!!!!!!!!


            //             GradeStatistics stats = book.ComputeStatistics();

            //             Console.ForegroundColor = ConsoleColor.Blue;
            //             Console.WriteLine("Here's the averages for your grades: ");
            //             Console.WriteLine(stats.AverageGrade);
            //             Console.WriteLine("");

            //             Console.ForegroundColor = ConsoleColor.Red;
            //             Console.WriteLine("Here's the highest grade: ");
            //             Console.WriteLine(stats.HighestGrade);
            //             Console.WriteLine("");

            //             Console.ForegroundColor = ConsoleColor.White;
            //             Console.WriteLine("Here's the lowest grade: ");
            //             Console.WriteLine(stats.LowestGrade);
        }
    }
}

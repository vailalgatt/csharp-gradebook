using System;
using System.Collections.Generic;

namespace Grades.Gradebook
{
    public class Class : IClass
    {
        public Student CurrentStudent { get; set; }

        public Boolean Playing = true;

        public void Reset()
        {

        }

        public void Setup()
        {
            Console.Clear();
            Console.WriteLine("\n---------Welcome to the Gradebook----------\n");
            CurrentStudent = new Student();
            Help();
        }

        public string GetUserInput()
        {
            System.Console.WriteLine("Press H to get a list of all your options");
            string input = Console.ReadLine();
            return input;
        }



        public Boolean Quit(Boolean playing)
        {
            System.Console.WriteLine("Leave the gradebook? Y/N");
            string input = Console.ReadLine().ToLower();
            if (input == "y" || input == "yes")
            {
                return playing = false;
            }
            else
            {
                System.Console.WriteLine("OK");
                return playing = true;
            }
        }
        public void Look(Class class)
        {
            System.Console.WriteLine($"{class.Name}:\n{class.Description}");
            for (int i = 0; i< class.Items.Count; i++)
            {
                System.Console.WriteLine($"Items: {class.Items[i].Name}\n");
            }
    System.Console.WriteLine($"Grade: {CurrentStudent.Grade}");
        }

        public void Help()
        {
            System.Console.WriteLine("Valid actions are class, grades, or student.\nEX: class, grades, student.\nLOOK or l: allows you to view a list of students, their corresponding grades, and a list of the average, lowest, and best grades overall. \nHELP or h: displays a list of all the commands needed for your gradebook.\nGIVE or g: adds an grade or student to your class list. EX: Give A ~ Vail.\nGRADEBOOK or g: Views everything in your gradebook.\nQUIT or q: leaves the gradebook.\n");
        }
    }
}
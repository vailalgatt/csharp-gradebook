using System;
using System.Collections.Generic;

namespace Grades.Gradebook
{
  public class Student : IStudent
  {
    public string StudentName;
    public int Grade { get; set; }
    public List<Class> Students { get; set; }
    public Student()
    {
      StudentName = NameStudent();
      Grade = 0;
      Students = new List<Class>();
    }
    public string NameStudent()
    {
      Console.WriteLine("What would you like your Students's name to be?\n");

      string StudentName = Console.ReadLine();

      Console.WriteLine("Great! Your student is now named " + StudentName + "\n");

      return StudentName;
    }
    public void ShowStudents(Student student)
    {
      System.Console.WriteLine("your students");
      for(int i = 0; i < student.Students.Count; i++){
        System.Console.WriteLine($"{student.Students[i].Name}\n {student.Students[i].Description}");
      }
    }
  }
}
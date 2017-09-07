using System.Collections.Generic;

namespace Grades.Gradebook

{
    public interface IClass 
    {
        Student CurrentStudent { get; set; }
        //add grades here 

        void Setup();
        void Reset();


    }
}
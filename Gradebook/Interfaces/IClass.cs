using System.Collections.Generic;

namespace Grades.Gradebook

{
    public interface IClass 
    {
        Student CurrentStudent { get; set; }

        void Setup();
        void Reset();


    }
}
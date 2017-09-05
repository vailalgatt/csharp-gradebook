using System.Collections.Generic;

namespace Grades.Gradebook

{
    public interface IGradebook 
    {
        Student CurrentStudent { get; set; }

        void Setup();
        void Reset();


    }
}
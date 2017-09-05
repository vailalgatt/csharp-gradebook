using System.Collections.Generic;

namespace Grades.Gradebook
{
    public interface IStudent
    {
        int Grade { get; set; }
        List<Class> Inventory { get; set; }

    }
}
using System.Collections.Generic;

namespace Grades.Gradebook
{
    public interface IStudent
    {
        int Grade { get; set; }
        List<Item> Inventory { get; set; }

    }
}
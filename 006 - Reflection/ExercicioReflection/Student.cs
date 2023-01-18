using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioReflection
{
    public class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }
        public int IdStudent { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Esse metodo você está vendo artavés da minha classe Student: {Name} - {University} - {RollNumber} - {IdStudent}");
        }
    }
}

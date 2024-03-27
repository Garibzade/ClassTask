using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson.classes
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;
    
   public Student(string name, string surname,string group,byte point,bool isgraduated)
    {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = isgraduated && point >= 65;
    }
        public void Getİnfo()
        {
            Console.WriteLine($"ad:{Name}");
            Console.WriteLine($"soyad:{Surname}");
            Console.WriteLine($"qrup:{Group}");
            Console.WriteLine($"bal:{Point}");
            Console.WriteLine($"mezun olub olmadigi:{(isGraduated ? "mezun" : "mezun deyil")}");
        }
        public void CheckGraduation()
        {
            if (isGraduated) Console.WriteLine("mezundur");
            else
            {
                Console.WriteLine("mezun deyil");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point < 65) Console.WriteLine("yoxdur");
            else if (Point <= 80 && Point > 65) Console.WriteLine("adi");
            else if (Point <= 90 && Point > 80) Console.WriteLine("seref");
            else Console.WriteLine("yuksek  seref");    
        }
}
}

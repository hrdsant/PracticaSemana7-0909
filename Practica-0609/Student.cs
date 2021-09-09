using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_0609
{
    class Student
    {
        public int idStudent { get; set; }
        public string firtsName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }

        // metodo con la coleeccion de datos 
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{ idStudent=1001, firtsName ="Jose", lastName = "Robles", age = 25, nationality = "Salvadoreño"},
                new Student{ idStudent=1002, firtsName ="Ana", lastName = "Lopez", age = 20, nationality = "Rusa"},
                new Student{ idStudent=1003, firtsName ="Rafael", lastName = "Gonzales", age = 21, nationality = "Español"},
                new Student{ idStudent=1004, firtsName ="Alfredo", lastName = "Valladares", age = 23, nationality = "Alemán"},
                new Student{ idStudent=1005, firtsName ="Amanda", lastName = "Flores", age = 22, nationality = "Italiana"},
                
            };
            return students; //retornamos la colección
        }


    }
}

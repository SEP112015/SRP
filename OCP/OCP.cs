using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
    }

    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso en línea
            Console.WriteLine($"{std.Name} ha sido suscrito al curso en línea: {Title}");
        }
    }

    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso presencial
            Console.WriteLine($"{std.Name} ha sido suscrito al curso presencial: {Title}");
        }
    }



    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // Código para suscribirse a un curso híbrido
            Console.WriteLine($"{std.Name} ha sido suscrito al curso híbrido: {Title}");
        }
    }

    // Clase Student para completar el ejemplo
    public class Student
    {
        public string Name { get; set; }
    }

    // Programa para probar la implementación
    class Program
    {
        static void Main()
        {
            Student student = new Student { Name = "Juan Pérez" };

            Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso de Programación en C#" };
            Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Curso de Electrónica" };
            Course hybridCourse = new HybridCourse { CourseId = 3, Title = "Curso de Desarrollo Web" };

            onlineCourse.Subscribe(student);
            offlineCourse.Subscribe(student);
            hybridCourse.Subscribe(student);
        }
    }




}

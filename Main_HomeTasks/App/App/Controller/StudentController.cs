using Domain.Models;
using Service.Service.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    internal class StudentController
    {
        private readonly StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }
        public void GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            foreach (var item in students)
            {
                string result = $"{item.FullName},{item.Age},{item.Email}";
                Console.WriteLine(result);
            }

        }


        public void GetStudentById()

        
        {
            var student = _studentService.GetById(3);
            string result = $"{student.FullName} - {student.Age}";
            Console.WriteLine(result);


        }


        public void ShowStudentsList()
        {


            Student[] students = _studentService.GetAllStudents();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FullName} - {student.Age}");
            }



            


        }



       

        public void SumOfAges()
        {
            var students = _studentService.GetAllStudents();
            var sumAge = students.Sum(x => x.Age);
            Console.WriteLine(sumAge);

        }

        public void GetAgesAvarage()
        {
            var students = _studentService.GetAllStudents();
            var sumAge = students.Sum(x => x.Age);
            Console.WriteLine(sumAge / students.Length);
        }
    }
}

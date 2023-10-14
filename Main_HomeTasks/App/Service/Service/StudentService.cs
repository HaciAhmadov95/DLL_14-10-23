using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Domain

{
    public class StudentService
    {
        private  Student[] GetAll()
        {
            return new Student[]
            {
                new Student {Id = 1, Age = 28, Email = "Ahmadov@gmail.com", FullName = "Haciaga Ahmadov"},
                 new Student {Id = 2, Age = 27, Email = "Aslanov@gmail.com", FullName = "Ali Aslanov"},
                  new Student {Id = 3, Age = 26, Email = "Ismayilov@gmail.com", FullName = "Elnur Ismayilov"},
                   new Student {Id = 4, Age = 25, Email = "Memmedov@gmail.com", FullName = "Leman Memmedova"},

            };
        }

        public Student[] GetAllStudents() => GetAll();
        

        public Student GetById(int id) => GetAll().FirstOrDefault(m => m.Id == id);

        public Student[] GetSortStudentsByAge()
        {
            Student[] students = GetAll();
            return students.OrderBy(m => m.Age).ToArray();
            //return students.OrderByDescending(m => m.Age).ToArray();
        }


        public Student[] GetAvarageOfStudents() => GetAll();
        

        


        

    }
}

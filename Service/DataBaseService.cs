using BlazorStudentsApp.Models;
using System;
using System.Collections.Generic;

namespace BlazorStudentsApp.Service
{
    public class DataBaseService : IDataBaseService
    {
        private List<Student> Students;
        private static int Id;
        public DataBaseService()
        {
            Students = new List<Student>();
            InitialAdd();
            Id = Students.Count + 1;
        }

        private void InitialAdd()
        {
            Students.Add(new Student
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Birthday = DateTime.Now,
                Studies = "Computer Science"
            });
            Students.Add(new Student
            {
                Id = 2,
                FirstName = "Richard",
                LastName = "Blake",
                Birthday = DateTime.Now,
                Studies = "Geology"
            });
            Students.Add(new Student
            {
                Id = 3,
                FirstName = "Monica",
                LastName = "Clark",
                Birthday = DateTime.Now,
                Studies = "Medicine"
            });
        }

        public void AddStudent(Student student)
        {
            student.Id = Id++;
            Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            Students.Remove(student);
        }


        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}

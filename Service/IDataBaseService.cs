using BlazorStudentsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudentsApp.Service
{
    interface IDataBaseService
    {
        public List<Student> GetStudents();
        public void AddStudent(Student student);
        public void DeleteStudent(Student student);
    }
}

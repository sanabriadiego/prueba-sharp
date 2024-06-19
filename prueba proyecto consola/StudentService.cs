using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_proyecto_consola
{
    class StudentService
    {
        private StudentRepository repository = new StudentRepository();

        public void AddStudent(string name)
        {
            Student newStudent = new Student { Name = name };
            repository.AddStudent(newStudent);
        }

        public List<Student> GetStudents()
        {
            return repository.GetAllStudents();
        }
    }
}

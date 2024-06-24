using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTests.Examples
{
    internal class RepositoryPattern
    {
        public interface IRepository<T>
        {
            IEnumerable<T> GetAll();
            T GetById(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(int id);
        }

        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class StudentRepository : IRepository<Student>
        {
            private readonly List<Student> _students = new List<Student>();

            public IEnumerable<Student> GetAll()
            {
                return _students;
            }

            public Student GetById(int id)
            {
                return _students.FirstOrDefault(s => s.Id == id);
            }

            public void Add(Student student)
            {
                _students.Add(student);
            }

            public void Update(Student student)
            {
                var existingStudent=GetById(student.Id);
                if (existingStudent!=null)
                {
                    existingStudent.FirstName = student.FirstName;
                    existingStudent.LastName = student.LastName;    
                }
            }

            public void Delete(int id)
            {
                var student=GetById(id);
                if (student!=null)
                {
                    _students.Remove(student);
                }
            }            
        }

        public static void Run()
        {
            IRepository<Student> studentRepository = new StudentRepository();

            studentRepository.Add(new Student { Id = 1, FirstName = "Ivan", LastName = "Ivanov" });
            studentRepository.Add(new Student { Id = 2, FirstName = "Petr", LastName = "Petrov" });
            studentRepository.Add(new Student { Id = 3, FirstName = "Petr", LastName = "Petrov" });

            var students=studentRepository.GetAll();
            foreach(var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}");
            }

            var studentToUpdate=studentRepository.GetById(1);
            if (studentToUpdate != null)
            {
                studentToUpdate.FirstName = "Ivan updated";
                studentRepository.Update(studentToUpdate);
            }

            studentRepository.Delete(2);

            students = studentRepository.GetAll();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}");
            }
        }
    }
}

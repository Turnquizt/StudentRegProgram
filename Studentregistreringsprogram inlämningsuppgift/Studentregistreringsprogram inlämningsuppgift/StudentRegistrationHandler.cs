using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentregistreringsprogram_inlämningsuppgift
{
    internal class StudentRegistrationHandler
    {
        public string SetStudentFirstName()
        {
            Console.Clear();
            Console.WriteLine("Enter your firstname.");
            string studentFirstName = Console.ReadLine();
            return studentFirstName;
        }
        public string SetStudentLastName() 
        {
            Console.Clear();
            Console.WriteLine("Enter your lastname.");
            string studentLastName = Console.ReadLine();
            return studentLastName;
        }
        public string SetStudentCity() 
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the city you live in.");
            string studentCity = Console.ReadLine();
            return studentCity;
        }
        public Student StudentAccountRegistrator() 
        {
            var student = new Student()
            {
                FirstName = SetStudentFirstName(),
                LastName = SetStudentLastName(),
                City = SetStudentCity()
            };
            return student;
        }
    }
}

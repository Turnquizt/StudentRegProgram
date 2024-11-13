using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentregistreringsprogram_inlämningsuppgift
{
    internal class StudentEditHandler
    {
        StudentDBContext sDBContext;
        public StudentEditHandler(StudentDBContext sDbCtxt)
        {
            sDBContext = sDbCtxt;
        }
        public void StudentEdit() 
        {
            Console.Clear();
            Student fetchedStudent = FetchAccount();
            Console.Clear();
            EditMenu(fetchedStudent);
            EditMenuChoice(fetchedStudent);
            sDBContext.SaveChanges();
        }
        public void EditMenu(Student fetchedStudent) 
        {
            Console.WriteLine("Currently fetched Account:");
            Console.WriteLine("{0,-5}\t{1,-15}\t{2,-15}\t{3,-15}", fetchedStudent.StudentId, fetchedStudent.FirstName, fetchedStudent.LastName, fetchedStudent.City);
            Console.WriteLine(" ");
            Console.WriteLine("1: Edit first name");
            Console.WriteLine("2: Edit last name");
            Console.WriteLine("3: Edit city");
        }
        public void EditMenuChoice(Student fetchedStudent) 
        {
            int editMenuChoice = Convert.ToInt32(Console.ReadLine());
            switch (editMenuChoice) 
            {
                case 1:
                    EditFirstName(fetchedStudent);
                    break;
                case 2:
                    EditLastName(fetchedStudent);
                    break;
                case 3:
                    EditCity(fetchedStudent);
                    break;
                default:
                    Console.WriteLine("Error: Menu choice not valid");
                    Thread.Sleep(3000);
                    break;
            }
        }
        public Student FetchAccount() 
        {
            
            Console.WriteLine("Enter the 'Id' of the account you want to edit");
            int chosenId = Convert.ToInt32(Console.ReadLine());
            var fetchedStudent = sDBContext.Students.Where(s => s.StudentId == chosenId).FirstOrDefault();
            return fetchedStudent;
        }
        public void EditFirstName(Student fetchedStudent) 
        {
            Console.WriteLine($"Enter new first name for id:{fetchedStudent.StudentId}");
            fetchedStudent.FirstName = Console.ReadLine();
        }
        public void EditLastName(Student fetchedStudent) 
        {
            Console.WriteLine($"Enter new last name for id:{fetchedStudent.StudentId}");
            fetchedStudent.LastName = Console.ReadLine();
        }
        public void EditCity(Student fetchedStudent) 
        {
            Console.WriteLine($"Enter new city for id:{fetchedStudent.StudentId}");
            fetchedStudent.City = Console.ReadLine();
        }
    }
}

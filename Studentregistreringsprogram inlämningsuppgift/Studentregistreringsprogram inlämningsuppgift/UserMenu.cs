using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentregistreringsprogram_inlämningsuppgift
{
    internal class UserMenu
    {
        StudentDBContext dbCtxt = new StudentDBContext();
        
        
        public void UserMenuChoice() 
        {
            Console.Clear();
            Console.WriteLine("StudentRegMenu");
            Console.WriteLine("1: Register a new student account");
            Console.WriteLine("2: Edit a student account");
            Console.WriteLine("3: Print stundent list");
            Console.WriteLine("4: Exit Program");

            int menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice) 
            {
                case 1:
                    StudentAccountRegistration();
                    break;
                case 2:
                    StudentAccountEdit();
                    break;
                case 3:
                    PrintStudentAccountList();
                    break;
                case 4:
                    dbCtxt.SaveChanges();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Error: Menu choice not valid");
                    Thread.Sleep(3000);
                    break;
            }
            
        }
        public void StudentAccountRegistration() 
        {
            StudentRegistrationHandler studentReg = new StudentRegistrationHandler();
            dbCtxt.Add(studentReg.StudentAccountRegistrator());
            dbCtxt.SaveChanges();
        }

        public void StudentAccountEdit() 
        {
            StudentEditHandler studentEdit = new StudentEditHandler(dbCtxt);
            studentEdit.StudentEdit();
        }


        string id = "Id";
        string firstName = "Firstname";
        string lastName = "Lastname";
        string city = "City";
        public void PrintStudentAccountList() 
        {
            StudentPrintHandler studentPrint = new StudentPrintHandler(dbCtxt);
            Console.Clear();
            Console.WriteLine($"{id}\t{firstName}\t{lastName}\t{city}");
            studentPrint.studentPrint();
            Console.WriteLine("press 'enter' to continue");
            Console.ReadLine();

        }
    }
}

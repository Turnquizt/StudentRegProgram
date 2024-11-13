using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentregistreringsprogram_inlämningsuppgift
{
    internal class StudentPrintHandler
    {
        StudentDBContext sDBContext;
        public StudentPrintHandler(StudentDBContext sDbCtxt)
        {
            sDBContext = sDbCtxt;
        }

        public void studentPrint() 
        {
            foreach (Student s in sDBContext.Students) 
            {
                Console.WriteLine("{0,-5}\t{1,-15}\t{2,-15}\t{3,-15}", s.StudentId, s.FirstName, s.LastName, s.City);
            }
        }
    }
}

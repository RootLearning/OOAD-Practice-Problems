using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Program : PrintStatements
    {
        static void Main(string[] args)
        {
            int TotalDays = 20;

            Student Student1 = new Student();
            Student1.Name = "H. Mohamed Thalif";
            Student1.Phone = "9894405020";
            Student1.Email = "thalif12@gmail.com";

            Student1.Degree.CollegeName = "Jamal Mohamed College";
            Student1.Degree.Location = "Trichy";
            Student1.Degree.Course = "MCA";
            Student1.Degree.CompletionStatus = true;

            Student1.RootIT.Course = Courses.Course.CompetitiveItermediate;
            Student1.RootIT.EnrolledDate = new DateTime(2019, 1, 12);

            Student1.RootIT.Topics = Student1.RootIT.TopicsCoveredData(new List<int> { 1, 2, 3, 4, 5, 8, 9 });

            Student1.RootIT.PaymentDetails.Add(new Payments(new DateTime(2019, 2, 2), 4000));
            Student1.RootIT.PaymentDetails.Add(new Payments(new DateTime(2019, 10, 12), 2000));
            Student1.RootIT.PaymentDetails.Add(new Payments(new DateTime(2020, 4, 4), 1000));

            Student1.RootIT.AttendanceData(new List<int> { 5, 6, 9, 10, 15 }, TotalDays);

            PrintDetails(Student1, TotalDays);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class PrintStatements
    {
        static public void PrintDetails(Student ob, int totalDays)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ob.Name + "\t\t" + ob.Email + "\t\t" + ob.Phone + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ob.Degree.Course);

            if (ob.Degree.CompletedStatus)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" [ Completed ]");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[ On Going ]");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t" + ob.Degree.CollegeName + " - " + ob.Degree.Location);
            PrintAttendance(ob.RootIT.Attendance, totalDays);
            PrintPaymentDetails(ob.RootIT.CourseName, ob.RootIT.PaymentDetails);
            PrintTopicDetails(ob.RootIT.CourseName, ob.RootIT.Topics);
        }
        static void PrintTopicDetails(string courseName, bool[] topicDetails)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + courseName + "\n");
            Console.ResetColor();
            for (int i = 0; i < topicDetails.Length; i++)
            {
                if (topicDetails[i])
                {
                    Console.Write("Topic_" + (i + 1) + " - ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("YES\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("Topic_" + (i + 1) + " - ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("NO\n");
                    Console.ResetColor();
                }

            }
        }
        static void PrintPaymentDetails(string courseName, List<Payments> paymentDetails)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\nPayment Details\t");
            Console.ResetColor();
            Console.Write(courseName + "[15000]\n");

            foreach (Payments item in paymentDetails)
                Console.WriteLine(item.Date.ToShortDateString() + " - " + item.Money);
        }
        static void PrintAttendance(List<bool> attendanceReport, int totalDays)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nAttendance");
            Console.ResetColor();

            int ForNextLine = 0;
            int AbsentCount = 0;
            foreach (bool item in attendanceReport)
            {
                ForNextLine++;
                if (item)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("X");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    AbsentCount++;
                    Console.Write("0");
                }
                if (ForNextLine == 7)
                {
                    Console.WriteLine();
                    ForNextLine = 0;
                }
            }
            Console.ResetColor();
            Console.WriteLine("\n" + (totalDays - AbsentCount) + " / " + AbsentCount);
        }
    }
}

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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(ob.Name + "\t\t" + ob.Email + "\t\t" + ob.Phone);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ob.Degree.Course);

            if (ob.Degree.CompletionStatus)
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
            Console.Write("\t-  " + ob.Degree.CollegeName + " - " + ob.Degree.Location);
            PrintAttendance(ob.RootIT.Attendance, totalDays);
            PrintPaymentDetails(ob.RootIT.SelectedCourse, ob.RootIT.PaymentDetails);
            PrintTopicDetails(ob.RootIT.TopicHisotry);
        }
        static void PrintTopicDetails(List<Topics> topicHistoy)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nTopics Coverd\t:\n");
            foreach (var item in topicHistoy)
            {
                if (item.TopicFrom.Equals(Topics.From.IN))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("[in] "+item.Topic);
                }
                else if (item.TopicFrom.Equals(Topics.From.OUT))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("[out] " + item.Topic);
                }
                if(item.IsCovered.Equals(Topics.Status.YES))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\t-  YES");
                }
                else if(item.IsCovered.Equals(Topics.Status.NO))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\t-  NO");
                }
                Console.WriteLine();
            }
        }
        static void PrintPaymentDetails(RootDetails.Course courseName, List<Payments> paymentDetails)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nPayment Details\t:\t");
            Console.ResetColor();
            Console.WriteLine("\n\t"+courseName +" - "+(int)courseName+"\n");

            foreach (Payments item in paymentDetails)
                Console.WriteLine("\t"+item.Date.ToShortDateString() + " - " + item.Money+"rs");

            int FeesPaid = (int)paymentDetails.Sum(o => o.Money);
            Console.Write("\t");
            if(FeesPaid < (int)courseName)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fees Pending\t|\t" + ((int)courseName - FeesPaid));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Paid Fully");
            }
            Console.ResetColor();
        }
        static void PrintAttendance(List<bool> attendanceReport, int totalDays)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\nAttendance\t:");
            Console.ResetColor();

            int ForNextLine = 0;
            int AbsentCount = 0;
            Console.Write("\n\t");
            foreach (bool item in attendanceReport)
            {
                ForNextLine++;
                if (item)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("X   ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    AbsentCount++;
                    Console.Write("0   ");
                }
                if (ForNextLine == 7)
                {
                    Console.WriteLine();
                    Console.Write("\t");
                    ForNextLine = 0;
                }
            }
            Console.ResetColor();
            Console.WriteLine("\n\tTotal Days....:"+ totalDays);
            Console.WriteLine("\tAbsent........:"+ AbsentCount);
        }
    }
}

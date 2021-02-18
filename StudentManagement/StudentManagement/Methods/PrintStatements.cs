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
            Console.WriteLine(ob.Name + "\t\t" + ob.Email + "\t\t" + ob.Phone + "\n");
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
            Console.Write("\t" + ob.Degree.CollegeName + " - " + ob.Degree.Location);
            PrintAttendance(ob.RootIT.Attendance, totalDays);
            PrintPaymentDetails(ob.RootIT.Course, ob.RootIT.PaymentDetails);
            PrintTopicDetails(ob.RootIT.Course, ob.RootIT.Topics);
        }
        static void PrintTopicDetails(RootDetails.Course course, bool[] topicDetails)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + course +"   [ Topics Covered ]"+"\n");
            Console.ResetColor();
            for (int i = 0; i < topicDetails.Length; i++)
            {
                if (topicDetails[i])
                {
                    Console.Write("Topic -" + (i + 1) + " - ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("YES\t");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("Topic -" + (i + 1) + " - ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("NO\t");
                    Console.ResetColor();
                }
                if(i % 2 == 0)
                    Console.WriteLine("\t");

            }
        }
        static void PrintPaymentDetails(RootDetails.Course courseName, List<Payments> paymentDetails)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n\nPayment Details\t:\t");
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
            Console.WriteLine("\n\nAttendance");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class RootDetails : Courses
    {
        public Course Course { get; set; }
        public DateTime EnrolledDate { get; set; }

        public bool[] Topics = new bool[10];
        public List<Payments> PaymentDetails = new List<Payments>();

        static List<bool> _attendance = new List<bool>();
        public List<bool> Attendance
        {
            get
            {
                return _attendance;
            }
        }
        static public void AddAtt(bool val)
        {
            _attendance.Add(val);
        }

        public void AttendanceData(List<int> LeaveDays, int totalDays)
        {
            for (int i = 0; i < totalDays; i++)
            {
                if (LeaveDays.Contains(i + 1))
                    AddAtt(false);
                else
                    AddAtt(true);
            }
        }
        public bool[] TopicsCoveredData(List<int> CoverdTopics)
        {
            bool[] FilledCoverdTopics = new bool[10];
            foreach (int TopicIndex in CoverdTopics)
                FilledCoverdTopics[TopicIndex - 1] = true;
            return FilledCoverdTopics;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class RootDetails : Courses
    {
        public Course SelectedCourse
        {
            get; set;
        }

        public DateTime EnrolledDate { get; set; }

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
        
    }
}

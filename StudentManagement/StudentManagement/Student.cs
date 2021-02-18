using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student : EducationDetails
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains('@'))
                    _email = value;
                else
                    _email = "@@@ Invalid Mail Entered @@@";
            }
        }

        public EducationDetails Education { get; set; }
    }
}

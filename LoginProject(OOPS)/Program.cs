using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject_OOPS_
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.AddAdmin();
            //u.AddStudent();
            //u.ValidateLogin( "Saffu", "1234");
            u.RemoveStudent();
        }
    }
}

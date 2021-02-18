using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin1
{
    public class User1
    {
        string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        string _PhoneNumber;

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        string _EmailId;

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }
        string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        string _HighestQualification;

        public string HighestQualification
        {
            get { return _HighestQualification; }
            set { _HighestQualification = value; }
        }
        string _PassedOut;

        public string PassedOut
        {
            get { return _PassedOut; }
            set { _PassedOut = value; }
        }
        string _CollegeName;

        public string CollegeName
        {
            get { return _CollegeName; }
            set { _CollegeName = value; }
        }
        string _City;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public User1()
        {
          
        }
        public void regisration()
        {
            User1 reg = new User1();
            List<User1> a = new List<User1>();
            Console.WriteLine("NAME :");
            reg.Name = Console.ReadLine();
            Console.WriteLine("PHONE NUMBER :");
            reg.PhoneNumber =Console.ReadLine();
            Console.WriteLine("ADDRESS :");
            reg.Address = Console.ReadLine();
            Console.WriteLine("EMAIL ID :");
            reg.EmailId = Console.ReadLine();
            Console.WriteLine("PASSED OUT :");
            reg.PassedOut = Console.ReadLine();
            Console.WriteLine("HIGHEST QUALIFICATION :");
            reg.HighestQualification = Console.ReadLine();
            Console.WriteLine("COLLEGE NAME  :");
            reg.CollegeName = Console.ReadLine();
            Console.WriteLine("CITY :");
            reg.City = Console.ReadLine();
            a.Add(reg);
            //foreach (var x in a)
            //{
            //    Console.WriteLine(x.Name+"\n"+x.PhoneNumber+"\n"+x.Address+"\n"+x.EmailId+"\n"+x.PassedOut +"\n"+x.HighestQualification+"\n"+x.CollegeName+"\n"+x.City);
            //}
        }
    }
    public class Admin
    {
        string _admin;

        public string Admin1
        {
            get { return _admin; }
            set { _admin = value; }
        }
        string _User;

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
    }
}

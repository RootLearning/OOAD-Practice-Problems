using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentslogin
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("REGISTER PRESS-1");
            Console.WriteLine(" LOGIN PRESS-2");
           
            int userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice == 1)
            {
                registerform log = new registerform();

                log.registerdata();
                log.login();
                
            }
            
            else if (userchoice == 2)
            {
                registerform log = new registerform();
                log.login();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
           
        }
    }
   public class registerform
    {

       List<registerform> l1 = new List<registerform>();
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string mailid;

        public string Mailid
        {
            get { return mailid; }
            set { mailid = value; }
        }
        int phonenumber;

        public int Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string educationqualification;

        public string Educationqualification
        {
            get { return educationqualification; }
            set { educationqualification = value; }
        }
        string collegename;

        public string Collegename
        {
            get { return collegename; }
            set { collegename = value; }
        }
        string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
       
        public void registerdata()
        {
            registerform log1 = new registerform();
            Console.WriteLine("******************REGISTER FORM*****************************");
            Console.WriteLine("NAME:");
            
            log1.Name = Console.ReadLine();
            Console.WriteLine("EMAIL ID:");
            log1.Mailid = Console.ReadLine();
            Console.WriteLine("PHONE NO:");
            log1.Phonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ADDRESS:");
            log1.Address = Console.ReadLine();
            Console.WriteLine("EDUCATION QUALIFICATION:");
            log1.Educationqualification = Console.ReadLine();
            Console.WriteLine("COLLEGE NAME:");
            log1.Collegename = Console.ReadLine();
            Console.WriteLine("CITY:");
            log1.City = Console.ReadLine();
            Console.WriteLine("USERNAME:");
            log1.Username = Console.ReadLine();
            Console.WriteLine("PASSWORD:");
            log1.Password = Console.ReadLine();
            l1.Add(log1);

            foreach (var s in l1)
            {
                Console.WriteLine(s.Name +"\n"+s.Mailid+"\n"+s.Phonenumber+"\n"+s.Address+"\n"+s.Educationqualification+"\n"+s.Collegename+"\n"+s.City+"\n"+s.Username+"\n"+s.Password);
                
            }
            Console.WriteLine("successfully register");
        }
       public void login()
       {
            
             Console.WriteLine("******************USER LOGIN**************************");
            Console.WriteLine("USER NAME");
            string user= Console.ReadLine();
            Console.WriteLine("PASSWORD");
            string pwd = Console.ReadLine();
            string check = "";
            foreach(var n in l1)
            {
                if (n.Username == user)
                {
                    if (n.Password == pwd)
                    {
                        check="login successfully";
                    }
                    else
                    {
                        check="invalid password";
                    }
                }
                else
                {
                  check="invalid username";
                }
                Console.WriteLine(check);
            }



        

        }
       
           
   }
       
        public class login
        {
            string username;

            public string Username
            {
                get { return username; }
                set { username = value; }
            }
            string password;

            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            public void admin()
            {
                Console.WriteLine("************************ADMIN LOGIN*******************");
                Console.WriteLine("USERNAME");
                Username = Console.ReadLine();
                Console.WriteLine("PASSWORD");
                Password = Console.ReadLine();
                Console.WriteLine("LOGIN SUCESSFULLY");
            }
        }
        
        
       
    }
   
        
    
   
   


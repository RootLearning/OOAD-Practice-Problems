using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject_OOPS_
{

    class User
    {
        List<UserDetails> GetUser= new List<UserDetails>();

        public User()
        {
        }
        //defaulfly set one admin
        public void AddAdmin()
        {
            UserDetails UD = new UserDetails();
            UD.Name = "Saffu";
            UD.Mail = "saffu@gmail.com";
            UD.Username = "Saffu"; 
            UD.Password = "1234";
            UD.UserType1 = UserState.Admin;
            GetUser.Add(UD);
        }
        public void AddStudent()
        {
            UserDetails UD = new UserDetails();
            Console.WriteLine("Name");
            UD.Name = Console.ReadLine();
            Console.WriteLine("Course");
            UD.Course = Console.ReadLine();
            Console.WriteLine("MailId");
            UD.Mail = Console.ReadLine();
            Console.WriteLine("User Name");
            string Username = Console.ReadLine();
            UsernameCheck(Username, UD);
            Console.WriteLine("Password");
            UD.Password = Console.ReadLine();
            UD.UserType1 = UserState.Student;
            GetUser.Add(UD);
            Console.WriteLine("User Registration Is Success");
        }
        public void UsernameCheck(string username, UserDetails Ud)
        {
            foreach (var check in GetUser)
            {
                if (check.Username == username)
                {
                    Console.WriteLine("Username is alreadry exist");
                    username = Console.ReadLine();
                    UsernameCheck(username,Ud);
                }
                else
                {
                    Ud.Username = username;
                }
            }
        }
        public void ValidateLogin(string username,string password)
        {
                foreach(var v in GetUser)
                {
                    if(v.Username==username && v.Password==password)
                    {
                        if(v.UserType1==UserState.Student)
                        {
                            Console.WriteLine("Student Logged in");
                        } 
                        else
                        {
                            Console.WriteLine("Admin Logged in");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
        }
        public void RemoveStudent()
        {
            UserDetails UD = new UserDetails();
            string username = Console.ReadLine();
            UserDetails GetUsernameDetails=new UserDetails() ;
            foreach(var v in GetUser)
            {
                if(v.Username==username)
                {
                    Console.WriteLine(v.Username);
                    Console.WriteLine(GetUser.Count);
                    GetUsernameDetails = v;
                }
            }
            GetUser.Remove(GetUsernameDetails);
            Console.WriteLine(GetUser.Count);
        }
        
        public void 
        
    }
    class UserDetails
    {
        string _name;
        string _mail;
        string _username;
        string _password;
        string _course;
        UserState _userType;
        public string Name { get => _name; set => _name = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Password { get => _password; set => _password = value; }
        public string Course { get => _course; set => _course = value; }
        public string Username { get => _username; set => _username = value; }
        public UserState UserType1 { get => _userType; set => _userType = value; }
    }
}

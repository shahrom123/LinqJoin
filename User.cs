using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class User
    {
        public string _firsName { get; set; }
        public string _lastName { get; set; } 
        public string _userName { get; set; } 
        public string _password { get; set; }

        public User(string firstName, string lastName, string userName, string password)
        {
            _firsName = firstName;
            _lastName = lastName;
            _userName = userName;
            _password = password;
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"FullName: {_firsName} {_lastName}");
            Console.WriteLine($"UserName: {_userName}");
            Console.WriteLine($"Password: {_password}");
        }

        public bool Login(string username,string password)
        {
           return (_userName == username && _password == password); 
        }
    }
}

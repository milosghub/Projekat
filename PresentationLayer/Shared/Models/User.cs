using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
   public class User
    {
        private int UserID;
        private string Name;
        private string Surname;
        private string Username;
        private string Password;
        private DateTime DateOfBirth;
        private string PhoneNumber;
        private string Email;
        private string Address;

        public int userid
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
        public string pass
        {
            get { return Password; }
            set { Password = value; }
        }
        public DateTime birth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }
        public string phone
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string mail
        {
            get { return Email; }
            set { Email = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
    }
}

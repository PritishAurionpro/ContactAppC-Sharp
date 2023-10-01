using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Model
{
    internal class User
    {
        private static int Id = 0;
        private bool IsAdmin;
        static List<User> Users = new List<User>();
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }
        public List<Contact> Contacts { get; set; }

        public User (string userName, int userAge, string userGender, bool isAdmin)
        {
            UserId = Id++;
            UserName = userName;
            UserAge = userAge;
            UserGender = userGender;
            IsAdmin = isAdmin;
            Contacts = new List<Contact>();
        }

        public static User CreateAdmin(string userName, int userAge, string userGender)
        {
            return new User (userName, userAge, userGender, true);
        }

        public User CreateUser(string userName, int userAge, string userGender)
        {
            //admin validation left
            //can use any object
            User newUser = new User(userName, userAge, userGender, false);
            Users.Add(newUser);
            return newUser;
        }

        public void GetAllUsers() 
        {
            foreach (var user in Users) 
            {
                Console.WriteLine($"User Id: {user.UserId}\nUser Name: {user.UserName}\nUser Age: {user.UserAge}" +
                    $"\nUser Gender: {user.UserGender}"); 
            }
            
        }

        public User FindUser(int userId)
        { //validate
            var foundUserObj = Users.Find(user => user.UserId == userId);
            return foundUserObj;
        }

        public void UpdateUser(int userId, int value)
        {
            var foundUserObj = FindUser(userId);
            foundUserObj.UserAge = value;
        }
        public void UpdateUser(int userId, string value)
        {
            var foundUserObj = FindUser(userId);
            foundUserObj.UserName = value;
        }
        public void DeleteUser(int userId)
        {
            var foundUserObj = FindUser(userId);
            Users.Remove(foundUserObj);
        }

        public void CreateContact(string contactName)
        {
            var newContact = new Contact (contactName);
            Contacts.Add(newContact);
        }

        public void GetAllContacts()
        {
            foreach(var contact in Contacts)
            {
                Console.WriteLine($"Contact ID: {contact.ContactId}\nContact Name: {contact.ContactName}");
            }
        }

        public Contact FindContact(int ContactId)
        {
            var foundContactObj = Contacts.Find(contact => contact.ContactId == ContactId);
            return foundContactObj;
        }

        public void UpdateContactName (int contactId, string value)
        {
            var foundContactObj = FindContact(contactId);
            foundContactObj.ContactName = value;
        }

        public void DeleteContact(int contactId)
        {
            var foundContactObj = FindContact(contactId);
            Contacts.Remove(foundContactObj);
        }
    
        public void CreateContactInfo(int contactId, string typeOfContactInfo, int valueOfContactInfo)
        {
            var foundContactObj = FindContact(contactId);
            foundContactObj.CreateContactInfo(typeOfContactInfo, valueOfContactInfo);
        }

        //public ContactInfo FindContactInfo(int contactId, int contactInfoId)
        //{
        //    var foundContactObj = FindContact(contactId);
        //    var foundContactInfoObj = foundContactObj.FindContactInfo(contactInfoId);
        //    return foundContactInfoObj;
        //}

        public void GetAllContactInfoByUser(int contactId)
        {
            var foundContactObj = FindContact(contactId);
            foundContactObj.GetAllContactInfo();
        }

        public void UpdateContactInfo(int contactId, int contactInfoId, string value)
        {
            var foundContactObj = FindContact(contactId);
            foundContactObj.UpdateContactInfo(contactInfoId, value);
        }
        public void UpdateContactInfo(int contactId, int contactInfoId, int value)
        {
            var foundContactObj = FindContact(contactId);
            foundContactObj.UpdateContactInfo(contactInfoId, value);
        }

        public void DeleteContactInfo(int contactId, int contactInfoId) 
        {
            var foundContactObj = FindContact(contactId);
            foundContactObj.DeleteContactInfo(contactInfoId);
            
        }

    }
}

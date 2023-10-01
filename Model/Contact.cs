using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Model
{
    internal class Contact
    {
        private static int Id = 0;
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public List<ContactInfo> ContactInfos { get; set; }

        public Contact(string contactName) 
        {
            ContactId = Id++;
            ContactName = contactName;
            ContactInfos = new List<ContactInfo>();
        }

        public void CreateContactInfo(string typeOfContactInfo, int valueOfContactInfo)
        {
            var newContactInfo = new ContactInfo(typeOfContactInfo, valueOfContactInfo);
            ContactInfos.Add(newContactInfo);
        }

        public void GetAllContactInfo()
        {
            foreach (var contact in ContactInfos)
            {
                Console.WriteLine($"Contact Info ID: {contact.ContactInfoId}" +
                    $"\nType of Contact Info: {contact.TypeOfContactInfo}" +
                    $"\nValue of Contact Info: {contact.ValueOfContactInfo}");
            }
        }

        public ContactInfo FindContactInfo(int contactInfoId)
        {
            var foundContactInfoObj = ContactInfos.Find(contactInfo => contactInfo.ContactInfoId == contactInfoId);
            return foundContactInfoObj;
        }

        public void UpdateContactInfo(int ContactInfoId, string value)
        {
            var foundContactInfoObj = FindContactInfo(ContactInfoId);
            foundContactInfoObj.TypeOfContactInfo = value;
        }
        public void UpdateContactInfo(int ContactInfoId, int value)
        {
            var foundContactInfoObj = FindContactInfo(ContactInfoId);
            foundContactInfoObj.ValueOfContactInfo = value;
        }

        public void DeleteContactInfo(int ContactInfoId) 
        {
            var foundContactInfoObj = FindContactInfo(ContactInfoId);
            ContactInfos.Remove(foundContactInfoObj);
        }
    }
       
}

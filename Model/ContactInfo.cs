using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Model
{
    internal class ContactInfo
    {
        private static int Id = 0;
        public int ContactInfoId { get; set; }
        public string TypeOfContactInfo { get; set; }
        public int ValueOfContactInfo { get; set; }
        public ContactInfo(string typeOfContactInfo, int valueOfContactInfo) 
        {
            ContactInfoId = Id++;
            TypeOfContactInfo = typeOfContactInfo;
            ValueOfContactInfo = valueOfContactInfo;
        }

        public void UpdateTypeOfContactInfo(object value)
        {
            this.TypeOfContactInfo = (string)value;
        }

        public void UpdateValueOfContactInfo(object value) 
        {
            this.ValueOfContactInfo = (int)value;
        }
    }
}

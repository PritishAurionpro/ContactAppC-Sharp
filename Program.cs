using ContactApp.Model;
namespace ContactApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var admin1 = User.CreateAdmin("Pritish", 21, "M");
            var user1 = admin1.CreateUser("Rahul", 21, "M");
            var user2 = admin1.CreateUser("Shreyas", 22, "M");
            user1.CreateContact("Ankith");
            user1.CreateContact("james");
            user2.CreateContact("bono");
            user1.CreateContactInfo(0, "home", 998975698);
            user1.CreateContactInfo(0, "work", 998973456);
            //admin1.GetAllUsers();
            //Console.WriteLine(user1.FindUser(1));
            //admin1.UpdateUser(1, 22);
            //admin1.UpdateUser(2, "Ankith");
            //admin1.DeleteUser(1);
            //admin1.GetAllUsers();

            //user1.UpdateContactName(0, "gp");
            //user1.DeleteContact(1);
            //user1.GetAllContacts();
            //user2.GetAllContacts();

            user1.UpdateContactInfo(0, 1, "office");
            user1.DeleteContactInfo(0, 0);
            user1.GetAllContactInfoByUser(0);


        }
    }
}
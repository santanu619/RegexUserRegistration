using System;

namespace RegexUserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Welcome to the User Registration Cell");
            bool firstName = pattern.firstNameCheck("Santanu");
            Console.WriteLine("FirstName " + firstName);
            bool lastName = pattern.lastNameCheck("Mohapatra");
            Console.WriteLine("LastName " + lastName);
            bool email = pattern.EmailCheck("mohapatra.santanu123@gmail.com");
            Console.WriteLine("Email " + email);
            bool mobile = pattern.MobileCheck(" 91 6294476694");
            Console.WriteLine("Mobile " + mobile);
            bool password = pattern.PasswordCheck("Myfamily@61923");
            Console.WriteLine("Password " + password);
            Console.ReadKey();
        }
    }
}

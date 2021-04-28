using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_ValidFirstName ucfirstname = new UC1_ValidFirstName();
            UC2_ValidLastName uclastname = new UC2_ValidLastName();
            UC3_ValidEmail ucemail = new UC3_ValidEmail();
            UC4_ValidPassword ucpassword = new UC4_ValidPassword();
            bool result1 = ucfirstname.validateFirstName("Santanu");
            bool result2 = uclastname.validateLastName("Mohapatra");
            bool result3 = ucemail.validateEmail("mohapatra.santanu123@gmail.com");
            bool result4 = ucpassword.validatePassword("Myfamily123");
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine("First Name is Valid!");
            Console.WriteLine("Please Proceed");
            Console.ReadKey();
        }
    }
}

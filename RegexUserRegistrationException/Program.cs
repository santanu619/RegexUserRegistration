using System;

namespace RegexUserRegistrationException
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void Main(string[] args)
            {
                PatternException pattern = new PatternException();
                bool isFirstNameCorrect = pattern.firstNameCheck("Santanu"); //'c' is small letter so validation returns false
                bool isLastNameCorrect = pattern.lastNameCheck("Mohapatra");
                bool isEmailCorrect = pattern.EmailCheck("mohapatra.santanu123@gmail.com");
                bool isMobileCorrect = pattern.MobileCheck("91 6294476694");
                bool isPasswordCorrect = pattern.PasswordCheck("santanu@123");
                try
                {
                    if (isFirstNameCorrect == false)
                    {
                        throw new Exception("First Name Validation False.s");
                    }
                    Console.WriteLine(isFirstNameCorrect);
                    Console.WriteLine(isLastNameCorrect);
                    Console.WriteLine(isEmailCorrect);
                    Console.WriteLine(isMobileCorrect);
                    Console.WriteLine(isPasswordCorrect);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Console.ReadKey();
            }
        }
    }
}

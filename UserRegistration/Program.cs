using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration validation using c#");
            Patterns pattern = new Patterns();
            //pattern.IsValidFirstName();
            //pattern.IsValidLastName();
            //pattern.IsValidEmail();
            //pattern.IsValidPhoneNo();
            pattern.IsValidPasswordRule1();
        }
    }
}

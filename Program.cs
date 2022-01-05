using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = IsValidEmail("mma @gma.com");
            Console.WriteLine(isOk);
        }
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Musiqi
{
    internal static class CustomExtension
    {
        public static bool CheckUsername(this string username)

        {
           if(string.IsNullOrEmpty(username) || username.Length<6 && username.Length >12 )
                    {
                          return false;
                    }
            if (username[0] == '.' || username[username.Length-1]=='.')
                return false;
            {

            }
            for (int i = 0; i < username.Length; i++)
            {
                if(!char.IsLetterOrDigit(username[i]) || username[i]! == '_' || username[i]!='.') 
                         {
                    Console.WriteLine("heyatdi da ZauR");
                    return false;
                         }
                {

                }
            }
            Console.WriteLine("duz");
            return true;

        }
        public static string Checkpassword(this string password)
          
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6 && password.Length > 12)
            {
                return true;
            }

            bool digit = false;
            bool upper = false;
            bool lower = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    upper = true;
                }
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }


            }
            return false;
            if (upper) 
            {
                
            }
          
        }
        public static string Capitalize(this string name)
        {
            name= name.Trim().ToLower();
            StringBuilder bulder= new StringBuilder();
            bulder.Append(char.ToUpper(name[0]));
            for (int i = 0; i < name.Length; i++)
            {
                bulder.Append(name[i]);
            }
            return bulder.ToString();
        }
    }
}

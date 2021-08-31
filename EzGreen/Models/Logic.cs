
using System;

namespace EzGreen.Models
{
    public class Logic
    {
        private const int MAX_USERS = 10;

        public static bool MaxUsers(int currenUser)
        {    
            if (currenUser > MAX_USERS)
            {
                return true;
            }
            return false;           
        }

        public static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }
    }
}

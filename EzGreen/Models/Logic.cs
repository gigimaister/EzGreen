using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzGreen.Models
{
    
    public class EzGreenProfile
    {
        private const int MAX_USERS = 10;

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public string ProfilePicture { get; set; }

        public bool MaxUsers(List<EzGreenProfile> ezGreenProfiles)
        {
            var numOfusers = ezGreenProfiles.Count();
            if(numOfusers == MAX_USERS)
            {
                return true;
            }
            return false;
        }
    }

    
}

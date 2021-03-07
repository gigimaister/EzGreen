using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EzGreen.Models
{
    
    public class EzGreenProfile
    {
        private const int MAX_USERS = 10;

        public int ProfileId { get; set; }

        [Required(ErrorMessage = "חייב לבחור שם!")]
        public string ProfileName { get; set; }

        [Required(ErrorMessage = "חייב לבחור תמונה!")]
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

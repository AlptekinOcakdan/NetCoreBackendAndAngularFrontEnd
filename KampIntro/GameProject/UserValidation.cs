using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidation : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Alptekin" && gamer.LastName == "Ocakdan" && gamer.IdentityNumber == 12312)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

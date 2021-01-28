using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 1985 && gamer.FistName == "engin" && gamer.LastName == "demir" && gamer.IdentyNumber == 123456789)
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

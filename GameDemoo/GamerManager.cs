using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoo
{//micro service
    
    class GamerManager : IGamerService
    {

        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService)
            Console.WriteLine("kayıt oldu");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("silindi");
        }
    }
}

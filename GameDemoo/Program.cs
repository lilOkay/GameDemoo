using System;

namespace GameDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "engin", LastName = "demiroğ", IdentyNumber = 123456789 });
        }
    }
}

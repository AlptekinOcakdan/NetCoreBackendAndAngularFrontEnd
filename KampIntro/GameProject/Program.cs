using System;

namespace GameProject // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidation());
            gamerManager.Add(new Gamer
                { Id = 1, BirthYear = 2000, FirstName = "Alptekin", LastName = "Ocakdan", IdentityNumber = 12312 });
        }
    }
}
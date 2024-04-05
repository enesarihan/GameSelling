using GameSelling.Abstract;
using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class GamerValidationManager : IGamerValidateService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.GamerId == 1 && gamer.GamerName == "Enes" && gamer.GamerTcNumber == 53863217642 && gamer.GamerLastName == "Sarıhan" && gamer.GamerDateOfBirth == 2003 )
            {
                Console.WriteLine("Kullanıcı Başarılı bir şekilde kimlik doğrulamadan geçmiştir.");
                return true;
            }
            else
            {
                Console.WriteLine("Bilgiler Yanlıştır.");
                return false;
            }
        }
    }
}

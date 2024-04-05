using GameSelling.Abstract;
using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerValidateService _gamerValidateService;

        public GamerManager(IGamerValidateService gamerValidateService)
        {
            _gamerValidateService=gamerValidateService;
        }

        public void Add(Gamer gamer)
        {
            if(_gamerValidateService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu Başarıyla Eklendi.");
            }
            else
            {
                Console.WriteLine("Bilgiler Yanlış olduğu için ekleme işlemi yapılamamıştır.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla silindi .");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Başarıyla Güncellendi.");
        }
    }
}

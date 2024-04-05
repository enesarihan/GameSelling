using GameSelling.Abstract;
using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyuncu Başarıyla Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyuncu Başarıyla Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyuncu Başarıyla Güncellendi.");
        }
    }
}

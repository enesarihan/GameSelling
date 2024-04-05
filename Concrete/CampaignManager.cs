using GameSelling.Abstract;
using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Başarıyla Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Başarıyla Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Başarıyla Güncellendi.");
        }
    }
}

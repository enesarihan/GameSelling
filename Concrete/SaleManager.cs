using GameSelling.Abstract;
using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class SaleManager:ISaleService
    {
        ICampaignService _campaignService;

        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        IGamerService _gamerService;

        public SaleManager(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }

        public void Add(Sale sale)
        {
            Console.WriteLine(sale.Gamer.GamerName + " " + sale.Gamer.GamerLastName + " bought " + sale.Game.GameName + " for " + sale.Price + " TL on " + sale.SaleDate + ".");

        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
    


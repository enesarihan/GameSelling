using GameSelling.Concrete;
using GameSelling.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            SaleManager saleManager = new SaleManager(gamerManager);
            CampaignManager campaignManager = new CampaignManager(); 

            Gamer gamer = new Gamer {
                GamerId=1,
                GamerDateOfBirth=2003,
                GamerLastName="Sarıhan",
                GamerName = "Enes",
                GamerTcNumber=53863217642
            };

            Game game = new Game {
                GameId = 1,
                GameName = "Red Dead Redemption 2",
                GamePrice = 6000
                
            };

            Sale sale = new Sale
            {
                Id = 1,
                Game = game,
                Gamer = gamer,
                SaleDate=DateTime.Today
            };
            Campaign campaign = new Campaign {
                Id = 1,
                Name="Red Dead Redemption 2",
                DiscountRate="%25"
            
            };

            gamerManager.Add(gamer);
            campaignManager.Add(campaign);
            saleManager.Add(sale);


            Console.ReadKey();
        }
    }
}

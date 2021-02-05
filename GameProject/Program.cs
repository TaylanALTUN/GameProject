using System;
using GameProject.Concrete;
using GameProject.Entity;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Taylan",
                LastName = "ALTUN",
                DateOfBirth = DateTime.Now,
                NationalityId = "12345678998"
            };

            Game game = new Game
            {
                Id = 1,
                Name = "ASSASSINS CREED VALHALLA",
                Detail = "Assassin's Creed Valhalla'da şanlı bir mücadeleye atılan Viking akıncısı Eivor olarak oyna.",
                Price = 1000,
                UnitStock = 4
            };

            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "İlk Oyun İndirimi",
                DiscountRate = 40
            };


            #region Customer Procesers
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            
            string addCustomerResult = customerManager.Add(customer);
            addCustomerResult= addCustomerResult + 
                               string.Format(" Oyuncu Ad Soyad: {0}  Kimlik No: {1}, Doğum Tarihi: {2}", customer.FullName, customer.NationalityId, customer.DateOfBirth);

            Console.WriteLine(addCustomerResult + " Oyuncu :" + customer.FullName);
            Console.WriteLine("*********************************************");

            customer.FirstName = "TAYLAN";

            string updateCustomerResult = customerManager.Update(customer);
            updateCustomerResult = updateCustomerResult +
                                   string.Format(" Oyuncu Ad Soyad: {0}  Kimlik No: {1}, Doğum Tarihi: {2}", customer.FullName, customer.NationalityId, customer.DateOfBirth);

            Console.WriteLine(updateCustomerResult + " Oyuncu :" + customer.FullName);
            Console.WriteLine("*********************************************");

            string deleteCustomerResult = customerManager.Delete(customer);

            Console.WriteLine(deleteCustomerResult);
            Console.WriteLine("*********************************************");
            #endregion

            #region Game Processor
            GameManager gameManager = new GameManager();

            string addGameResult = gameManager.Add(game);
            addGameResult = addGameResult +
                            string.Format(" Oyun Adı: {0} Detayı: {1}, Stok Adedi: {2}, Fiyatı: {3} ", game.Name, game.Detail, game.UnitStock, game.Price);

            Console.WriteLine(addGameResult);
            Console.WriteLine("*********************************************");

            game.UnitStock = 5;

            string updateGameResult = gameManager.Update(game);
            updateGameResult = updateGameResult +
                               string.Format(" Oyun Adı: {0}  Detayı: {1}, Stok Adedi: {2}, Fiyatı: {3} ", game.Name, game.Detail, game.UnitStock, game.Price);

            Console.WriteLine(updateGameResult );
            Console.WriteLine("*********************************************");

            string deleteGameResult = gameManager.Delete(game);

            Console.WriteLine(deleteGameResult);
            Console.WriteLine("*********************************************");
            #endregion

            #region Campaign Processor
            CampaignManager campaignManager = new CampaignManager();

            string addCampaignResult = campaignManager.Add(campaign);
            addCampaignResult = addCampaignResult +
                                string.Format(" Kampanya Adı: {0}  İndirim Oranı: {1}", campaign.CampaignName, campaign.DiscountRate);

            Console.WriteLine(addCampaignResult);
            Console.WriteLine("*********************************************");

            campaign.DiscountRate = 50;

            string updateCampaignResult = campaignManager.Update(campaign);
            updateCampaignResult = updateCampaignResult +
                                   string.Format(" Kampanya Adı: {0}  İndirim Oranı: {1}", campaign.CampaignName, campaign.DiscountRate);

            Console.WriteLine(updateCampaignResult + " Oyuncu :" + customer.FullName);
            Console.WriteLine("*********************************************");

            string deleteCampaignResult = campaignManager.Delete(campaign);

            Console.WriteLine(deleteCampaignResult);
            Console.WriteLine("*********************************************"); 
            #endregion

            SalesManager salesManager = new SalesManager();

            string salesResult = salesManager.Sale(customer, game, campaign);
            
            Console.WriteLine(salesResult);
            Console.WriteLine("*********************************************");

            salesResult = salesManager.Sale(customer, game, null);
            
            Console.WriteLine(salesResult);
            Console.WriteLine("*********************************************");

        }
    }
}

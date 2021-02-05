using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class SalesManager:ISalesService
    {
        public string Sale(Customer customer, Game game, Campaign campaign)
        {
            string result = "";
            if (customer != null && game != null && campaign != null)
            {
                double salePrice = game.Price - ((game.Price / 100) * campaign.DiscountRate);

                result = string.Format("Kampanyalı satış başarılı.  Oyuncu Ad Soyad: {0}, Oyun Adı: {1}, Oyun Fiyatı: {2}, İndirim Oranı: {3}", customer.FullName, game.Name, salePrice, campaign.DiscountRate);
            }
            else if (customer != null && game != null)
            {
                result = string.Format("Satış başarılı.  Oyuncu Ad Soyad: {0}, Oyun Adı: {1}, Oyun Fiyatı: {2}", customer.FullName, game.Name, game.Price);
            }
            else
            {
                result = "Satış başarısız";
            }
            return result;
        }
    }
}

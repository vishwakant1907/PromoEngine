using PromotionEngine.PromoCalculation.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.PromoCalculation.PromoConcreate
{
    public class ProductC : IProductC
    {
        public int CalculateAmoutForC(int Quantity)
        {
            int calPromoC = 0;
            int promoQuantity = Convert.ToInt32(ConfigurationManager.AppSettings["PromoQuantityForC"]);
            int PromoPrice = Convert.ToInt32(ConfigurationManager.AppSettings["PromoPriceForC"]);


            try
            {
                  if (Quantity >= promoQuantity)
                {
                    calPromoC = PromoPrice * Quantity;
                }
                   
            }
            catch(Exception ex)
            {

            }
            return calPromoC;
        }
    }
}

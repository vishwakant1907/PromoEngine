using PromotionEngine.PromoCalculation.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.PromoCalculation.PromoConcreate
{
    public class ProductD : IProductD
    {
        public int CalculateAmoutForD(int Quantity)
        {
            int calPromoD = 0;
            int promoQuantity = Convert.ToInt32(ConfigurationManager.AppSettings["PromoQuantityForD"]);
            int PromoPrice = Convert.ToInt32(ConfigurationManager.AppSettings["PromoPriceForD"]);
            try
            {
                if (Quantity >= promoQuantity)
                {
                    calPromoD = PromoPrice * Quantity;
                }

            }
            catch (Exception ex)
            {

            }
            return calPromoD;

        }
    }
}

using PromotionEngine.PromoCalculation.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.PromoCalculation.PromoConcreate
{
   public class ProductB:IProductB
    {
        public int CalculateAmoutForB(int Quantity)
        {
            int   xB = 0,  sB, calPromoB=0, remainder;
            int promoQuantity = Convert.ToInt32(ConfigurationManager.AppSettings["PromoQuantityForB"]);
            int PromoPrice = Convert.ToInt32(ConfigurationManager.AppSettings["PromoPriceForB"]);
            try
            {
                if (Quantity >= promoQuantity)
                {
                    double quotientB = Math.DivRem(Quantity, promoQuantity, out remainder);
                    int res = (int)Math.Round(quotientB, 0);
                    if (remainder == 0)
                    {
                        xB = PromoPrice * res;
                        calPromoB = xB;
                    }
                    else
                    {
                        xB = PromoPrice * res;
                        sB = 30 * remainder;
                        calPromoB = xB + sB;
                    }
                }
                else
                {
                    calPromoB = 30 * Quantity;
                }
            }
            catch(Exception ex)
            {

            }
            return calPromoB;
        }
    }
}

using PromotionEngine.PromoCalculation.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.PromoCalculation.PromoConcreate
{
    public class ProductA : IProductA
    {
        public int CalculateAmoutForA(int Quantity)
        {
            int xA = 0, sA, calPromoA=0, remainder;
            int promoQuantity = Convert.ToInt32(ConfigurationManager.AppSettings["PromoQuantityForA"]);
            int PromoPrice= Convert.ToInt32(ConfigurationManager.AppSettings["PromoPriceForA"]);
            try
            {

                if (Quantity >= promoQuantity)
                {
                    double quotientA = Math.DivRem(Quantity, promoQuantity, out remainder);
                    int res = (int)Math.Round(quotientA, 0);
                    if (remainder == 0)
                    {
                        xA = PromoPrice * res;
                        calPromoA = xA;
                    }
                    else
                    {
                        xA = PromoPrice * res;
                        sA = 50 * remainder;
                        calPromoA = xA + sA;
                    }
                }
                else
                {
                    calPromoA = 50 * Quantity;
                }
            }
            catch (Exception ex)
            {

            }
            return calPromoA;
        }
    }
}

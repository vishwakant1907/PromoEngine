using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Concrete
{
    public class Promotion : IPromotion
    {
        public int ApplyPromo(int QuantityA, int QuantityB, int QuantityC, int QuantityD)
        {
            int xA = 0, xB = 0, cA, cB, calPromoA,
                calPromoB, calPromoCD,TotalPrice = 0,
                remainder;
            try
            {
               
                if (QuantityA > 3)
                {
                    double quotientA = Math.DivRem(QuantityA, 3, out remainder);
                    int res = (int)Math.Round(quotientA, 0);
                    if (remainder == 0)
                    {
                        xA = 130 * res;
                        calPromoA = xA;
                    }
                    else
                    {
                        xA = 130 * res;
                        cA = 50 * remainder;
                        calPromoA = xA + cA;
                    }
                    // cA = 50 * QuantityA;

                }
                else
                {
                    calPromoA = 50 * QuantityA;
                }
                if (QuantityB > 2)
                {
                    double quotientB = Math.DivRem(QuantityB, 2, out remainder);
                    int res = (int)Math.Round(quotientB, 0);
                    if (remainder == 0)
                    {
                        xB = 45 * res;
                        calPromoB = xB;
                    }
                    else
                    {
                        xB = 45 * res;
                        cB = 30 * remainder;
                        calPromoB = xB + cB;
                    }
                }
                else
                {
                    calPromoB = 30 * QuantityB;
                }

                if (QuantityC == 1 && QuantityD == 1)
                {
                    calPromoCD = 30;
                }
                else if (QuantityC == 1 && QuantityD == 0)
                {
                    calPromoCD = 20;
                }
                else if (QuantityC == 0 && QuantityD == 1)
                {
                    calPromoCD = 15;
                }
                else
                {
                    calPromoCD = (20 * QuantityC) + (15 * QuantityD);
                }
                TotalPrice = calPromoA + calPromoB + calPromoCD;
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return TotalPrice;
        }

           
    }
}

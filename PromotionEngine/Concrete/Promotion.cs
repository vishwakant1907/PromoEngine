using PromotionEngine.Interface;
using PromotionEngine.PromoCalculation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Concrete
{
    public class Promotion : IPromotion
    {
        private readonly IProductA _productA;
        private readonly IProductB _productB;
        private readonly IProductC _productC;
        private readonly IProductD _productD;
        public Promotion(IProductA productA, IProductB productB,
                         IProductC productC, IProductD productD)
        {
            _productA = productA;
            _productB = productB;
            _productC = productC;
            _productD = productD;

        }
        public int ApplyPromo(int QuantityA, int QuantityB, int QuantityC, int QuantityD)
        {
            int TotalPrice = 0,PromoCD=0;
           
            //Get calPromoFor A
            int promoA = _productA.CalculateAmoutForA(QuantityA);
            //Get calPromoFor B
            int promoB = _productB.CalculateAmoutForB(QuantityB);
            if (QuantityC == 1 && QuantityD == 1)
            {
                PromoCD = 30;

                TotalPrice = promoA + promoB + PromoCD;
            }
            else
            { 
             //Get calPromoFor c
             int promoC = _productC.CalculateAmoutForC(QuantityC);
            //Get calPromoFor D
            int promoD = _productD.CalculateAmoutForD(QuantityD);
                TotalPrice = promoA + promoB + promoC + promoD;
            }
            return TotalPrice;

        }



    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Concrete;
using PromotionEngine.Interface;

namespace PromotionEngineUnitTestCase
{
    [TestClass]
    public class PromotionEngineUT
    {
        readonly IPromotion promotion = new Promotion();
        [TestMethod]
        public void  CalculatePomotionShouldPassWithGivenCheckoutAmount()
        {
            int CheckoutAmount = 370;
            int QuantityA = 5, QuantityB = 5, QuantityC = 1, QuantityD = 0;
            int result = promotion.ApplyPromo(QuantityA, QuantityB, QuantityC, QuantityD);
            Assert.AreEqual(CheckoutAmount, result);

        }

        [TestMethod]
        public void CalculatePomotionShouldFailWithGivenCheckoutAmount()
        {
            int CheckoutAmount = 270;
            int QuantityA = 5, QuantityB = 5, QuantityC = 1, QuantityD = 0;
            int result = promotion.ApplyPromo(QuantityA, QuantityB, QuantityC, QuantityD);
            Assert.AreNotEqual(CheckoutAmount, result);

        }
    }
}

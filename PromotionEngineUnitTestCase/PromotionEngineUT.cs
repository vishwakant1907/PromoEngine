using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PromotionEngine.Concrete;
using PromotionEngine.Interface;
using PromotionEngine.PromoCalculation.Interface;

namespace PromotionEngineUnitTestCase
{
    [TestClass]
    public class PromotionEngineUT
    {
        Mock<IProductA> mockProductA;
        Mock<IProductB> mockProductB;
        Mock<IProductC> mockProductC;
        Mock<IProductD> mockProductD;
        IPromotion promotion;
        public PromotionEngineUT()
        {
            mockProductA = new Mock<IProductA>();
            mockProductB = new Mock<IProductB>();
            mockProductC = new Mock<IProductC>();
            mockProductD = new Mock<IProductD>();
            promotion = new Promotion(mockProductA.Object, mockProductB.Object,
                                               mockProductC.Object, mockProductD.Object);

        }

         
        [TestMethod]
        public void  CalculatePomotionShouldPassWithGivenCheckoutAmount()
        {
            int CheckoutAmount = 370;
            int QuantityA = 5, QuantityB = 5, QuantityC = 1, QuantityD = 0;
            var pA = mockProductA.Setup(x => x.CalculateAmoutForA(QuantityA)).Returns(230);
            var pB = mockProductB.Setup(x => x.CalculateAmoutForB(QuantityB)).Returns(120);
            var pc = mockProductC.Setup(x => x.CalculateAmoutForC(QuantityC)).Returns(20);
            var pD = mockProductD.Setup(x => x.CalculateAmoutForD(QuantityC)).Returns(0);

            int result = promotion.ApplyPromo(QuantityA, QuantityB, QuantityC, QuantityD);
            Assert.AreEqual(CheckoutAmount, result);

        }

        [TestMethod]
        public void CalculatePomotionShouldFailWithGivenCheckoutAmount()
        {
            int CheckoutAmount = 270;
            int QuantityA = 5, QuantityB = 5, QuantityC = 1, QuantityD = 0;
            var pA = mockProductA.Setup(x => x.CalculateAmoutForA(QuantityA)).Returns(230);
            var pB = mockProductB.Setup(x => x.CalculateAmoutForB(QuantityB)).Returns(120);
            var pc = mockProductC.Setup(x => x.CalculateAmoutForC(QuantityC)).Returns(20);
            var pD = mockProductD.Setup(x => x.CalculateAmoutForD(QuantityC)).Returns(0);
            int result = promotion.ApplyPromo(QuantityA, QuantityB, QuantityC, QuantityD);
            Assert.AreNotEqual(CheckoutAmount, result);

        }
    }
}

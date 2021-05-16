using PromotionEngine.Concrete;
using PromotionEngine.Interface;
using PromotionEngine.PromoCalculation.Interface;
using PromotionEngine.PromoCalculation.PromoConcreate;
using Unity;

namespace PromotionEngine.Utilities
{
    static class UnityConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UnityContainer Register()
        {
            var container = new UnityContainer();
            container.RegisterType<IPromotion, Promotion>();
            container.RegisterType<IProductA, ProductA>();
            container.RegisterType<IProductB, ProductB>();
            container.RegisterType<IProductC, ProductC>();
            container.RegisterType<IProductD, ProductD>();
            return container;
        }
    }
}

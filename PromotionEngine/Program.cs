using PromotionEngine.Interface;
using System;

namespace PromotionEngine
{
    public class Program
    {

       
        static void Main(string[] args)
        {
            
            IPromotion promotion = new PromotionEngine.Concrete.Promotion();
            Console.WriteLine("Please see the option in promo and based on that select your SKU Qunatity from\navailable Items, based on your selected quantity discount promo will apply.", Console.ForegroundColor=ConsoleColor.Magenta);
            Console.WriteLine("\nPlease Enter Zero(0) for those SKU which you don't want to Include for checkout.\n 1.Unit Price for A=50 \n 2.Unit price for B=30" +
                "\n 3.Unit price for c=20 \n 4.Unit price for D=15"+
                "\n\n Active Promotion option:"+
                "\n 1.3 of A's for 130." +
                "\n 2.2 of B's for 50." +
                "\n 3.C & D for 30", Console.ForegroundColor=ConsoleColor.DarkGreen
                );
            Console.WriteLine("\nEnter the quantity of SKU unit for product A.");
            int QuantityA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of SKU unit for product B.");
            int QuantityB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of SKU unit for product C.");
            int QuantityC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of SKU unit for product D.");
            int QuantityD = Convert.ToInt32(Console.ReadLine());

            int TotalCheckoutPrice=  promotion.ApplyPromo(QuantityA,QuantityB,QuantityC,QuantityD);
            Console.WriteLine("Total price after applying PromoCode:=" + TotalCheckoutPrice,Console.BackgroundColor=ConsoleColor.White);
            Console.Read();

        }
    }
}

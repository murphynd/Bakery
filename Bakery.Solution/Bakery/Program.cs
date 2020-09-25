using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      string intro = "Hello and Welcome to Pierre's Bakery.\n" +
      "Today we have fresh bread for $5 a loaf.\n" +
      "We also have delecious pasteries for just $2 a peice\n" +
      "Feeling Hungry? well check out our deals: \n " +
      "\n" +
      "Bread is buy 2 get one free // Pastery of your choice 3 for $5!\n";
      string title = @"

       ___  __  ___  ___   ___   ___  _  ___    ___   __   _ _   ___  ___  
(  ,\(  )(  _)(  ,) (  ,) (  _)/_)/ __)  (  ,) (  ) ( ) ) (  _)(  ,) ( \/ )
 ) _/ )(  ) _) )  \  )  \  ) _)   \__ \   ) ,\ /__\  )  \  ) _) )  \  \  / 
(_)  (__)(___)(_)\_)(_)\_)(___)   (___/  (___/(_)(_)(_)\_)(___)(_)\_)(__/  ";

      Console.WriteLine(title);
      Console.WriteLine();
      Console.WriteLine(intro);
      Console.Write("Enter how many loafs you would like: ");
      int loafs = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter how many Pasteries you would like: ");
      int sweets = Convert.ToInt32(Console.ReadLine());
      Bread breadOrder = new Bread(loafs);
      Pastery sweetOrder = new Pastery(sweets);
      int billTotal = sweetOrder.PasteryRegPrice() + breadOrder.BreadRegPrice();
      int salePrice = breadOrder.BreadSale() + sweetOrder.PasterySale();
      int ammountSaved = billTotal - salePrice;
      Console.WriteLine();
      Console.WriteLine($"Bill total:\t{billTotal,8:c}");
      Console.WriteLine($"You Saved:\t{ammountSaved,8:c}");
      Console.WriteLine(("").PadRight(24, '-'));
      Console.WriteLine($"Grand total:\t{salePrice,8:c}");
    }
  }
}

using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello and Welcome to Pierres Bakery.\n" +
      "Today we have fresh bread for $5 a loaf.\n" +
     "We also have delecious pasteries for just $2 a peice\n" +
      "Feeling Hungry? well check out our deals: \n " +
      "Bread is buy 2 get one free // Pastery of your choice 3 for $5!\n");
      Console.Write("Enter How many Loafs you would like: ");
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

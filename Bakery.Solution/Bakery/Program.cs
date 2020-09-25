using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
    public static void Main(string[] args)
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

    }
    // public static void Main()
    // {
    //   Console.WriteLine("Hello and Welcome to Pierres Bakery.");
    //   Console.WriteLine("Today we have fresh bread for $5 a loaf.");
    //   Console.WriteLine("We also have delecious pasteries for just $2 a peice");
    //   Console.WriteLine("Feeling Hungry? well check out our deals: ");
    //   Console.WriteLine("Bread is buy 2 get one free // Pastery of your choice 3 for $5!");


    //   // int input = Console.ReadLine();
    //   // Console.WriteLine("The score is " + Words.getWordScore(input));
    // }
  }
}

using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public Bread(int amount)
    {
      Amount = amount;
    }
    public int BreadRegPrice()
    {
      int price = 5;
      int regPrice = price * Amount;
      return (regPrice);
    }
    public int BreadSale()
    {
      int SalePrice = (Amount / 3) * 10;
      SalePrice += (Amount % 3) * 5;
      return (SalePrice);
    }
  }
  public class Pastery
  {
    public int Amount { get; set; }
    public Pastery(int amount)
    {
      Amount = amount;
    }
    public int PasteryRegPrice()
    {
      int price = 2;
      int regPrice = price * Amount;
      return (regPrice);
    }
  }
}

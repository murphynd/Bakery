using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]

  public class BakeryTests
  {
    [TestMethod]
    public void Createbread_BreadRegInt_Int()
    {
      //Arrange
      int input = 3;
      //Act
      Bread newOrder = new Bread(input);
      //Assert
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }
    [TestMethod]
    public void getInput_BreadRegPricecheck_Int()
    {
      //Arrange
      int input = 2;
      int result = 10;
      Bread newOrder = new Bread(input);
      //Act
      int sale = newOrder.BreadRegPrice();
      //Assert
      Assert.AreEqual(result, sale);
    }
    [TestMethod]
    public void getInput_BreadSale_Int()
    {
      //Arrange
      int input = 7;
      int result = 25;
      Bread newOrder = new Bread(input);
      //Act
      int sale = newOrder.BreadSale();
      //Assert
      Assert.AreEqual(result, sale);
    }
    [TestMethod]
    public void CreatePasteryOrder_PasteryRegInt_Int()
    {
      //Arrange
      int input = 3;
      //Act
      Pastery newOrder = new Pastery(input);
      //Assert
      Assert.AreEqual(typeof(Pastery), newOrder.GetType());
    }
    [TestMethod]
    public void getInput_PastryRegPricecheck_Int()
    {
      //Arrange
      int input = 2;
      int result = 4;
      Pastery newOrder = new Pastery(input);
      //Act
      int sale = newOrder.PasteryRegPrice();
      //Assert
      Assert.AreEqual(result, sale);
    }
    [TestMethod]
    public void getInput_PastrySale_Int()
    {
      //Arrange
      int input = 4;
      int result = 7;
      Pastery newOrder = new Pastery(input);
      //Act
      int sale = newOrder.PasterySale();
      //Assert
      Assert.AreEqual(result, sale);
    }
  }
}




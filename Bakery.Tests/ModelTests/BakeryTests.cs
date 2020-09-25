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
  }
}
//     [TestMethod]
//     public void getInput_BreadRegInt_Int()
//     {
//       //Arrange
//       int input = 3;
//       int result = 15;

//       //Act
//       int sale = Bread.BreadReg(input);

//       //Assert
//       Assert.AreEqual(sale, result);
//     }

//     [TestMethod]
//     public void getInput_BreadSalecheck_Int()
//     {
//       //Arrange
//       int input = 2;
//       int result = 10;

//       //Act
//       int sale = Bread.BreadSale(input);

//       //Assert
//       Assert.AreEqual(result, sale);
//     }
//   }
// }
//[TestMethod]
// public void GetWord_ReturnsWord_String()
// {
//   //Arrange
//   string input = "Walk";

//   //Act
//   Words newWord = new Words(input);
//   string result = newWord.Input;

//   //Assert
//   Assert.AreEqual(input, result);
// }
// [TestMethod]
// public void GetWord_ReturnsWord_array()
// {
//   //Arrange
//   string input = "Walk";
//   Words newWord = new Words(input);

//   //Act

//   char[] array = input.ToCharArray();
//   char[] result = newWord.ToArray(input);
//   Console.WriteLine(result);

//   //Assert
//   CollectionAssert.AreEqual(array, result);
// }
// [TestMethod]
// public void GetWord_Returnspoints_int()
// {
//   //Arrange
//   string input = "Walk";
//   Words newWord = new Words(input);
//   char[] array = newWord.ToArray(input);

//   //Act
//   //method called on to check array against a dictionary int 
//   int points = newWord.CheckPoints(array);
//   int result = 13;
//   Console.WriteLine(result);

//   //Assert
//   Assert.AreEqual(points, result);
// }


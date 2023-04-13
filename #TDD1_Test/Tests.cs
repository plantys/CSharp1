using _TDD1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _TDD1_Test {
 internal class Tests {
  [TestFixture]
  public class TDD1Test {
   [Test]
   public void AddNumbers_InputTwoInt_GetCorrectAddition() {
    //Arrange
    Calculator calc = new();

    //Act
    int result = calc.AddNumbers(10, 20);

    //Assert
    Assert.AreEqual(30, result);
   }
   [Test]
   public void IsOdd_InputOdd_GetCorrectAnswer() {
     //Arrange
     Calculator calc = new();

     //Act
     bool result = calc.IsOddNumber(11);

     //Assert
     Assert.AreEqual(true, result);
    }
   [Test]
   public void IsOdd_InputEven_GetCorrectAnswer() {
    //Arrange
    Calculator calc = new();
    //Act
    bool result = calc.IsOddNumber(10);
    //Assert
    Assert.AreEqual(false, result);
   }
  }
 }
}

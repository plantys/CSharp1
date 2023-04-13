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
   [TestCase(11.1,11.2 )]
   public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b) {
    //Arrange
    Calculator calc = new();

    //Act
double result = calc.AddNumbersDouble(a,b);

    //Assert
    Assert.AreEqual(22.3, result, 1);
   }


   [Test]
   [TestCase(10, ExpectedResult = false)]
   [TestCase(11, ExpectedResult = true)]
   public bool IsOdd_InputAny_ReturnTrueIfOdd(int a) {
    //Arrange
    Calculator calc = new();

    //Act
    return calc.IsOddNumber(a);

    //Assert

   }
   
   [Test]
   public void AddNumbers_InputTwoInt_GetCorrectAddition() {
    //Arrange
    Calculator calc = new();

    //Act
    int result = calc.AddNumbers(10, 20);

    //Assert
    Assert.That(30, Is.EqualTo(result));
   }
   [Test]
   [TestCase(11)]
   [TestCase(13)]
   public void IsOdd_InputOdd_GetCorrectAnswer(int a) {
     //Arrange
     Calculator calc = new();

     //Act
     bool result = calc.IsOddNumber(a);

     //Assert
     Assert.That( result, Is.True);
    }
   [Test]
   public void IsOdd_InputEven_GetCorrectAnswer() {
    //Arrange
    Calculator calc = new();
    //Act
    bool result = calc.IsOddNumber(10);
    //Assert
    Assert.That(result, Is.False);
   }
  }
 }
}

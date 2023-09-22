using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System.Reflection.Metadata;
using System;

namespace BakeryApp.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void GetOrder_GetsOrder_Void()
    {
      Bread newBread = new();
      int newOrder = 6;
      newBread.CalcPrice(newOrder);
      Assert.AreEqual(newOrder, newBread.Order);
    }

    [TestMethod]
    public void SetOrder_SetsOrder_Void()
    {
      Bread newBread = new();
      newBread.CalcPrice(3);
      int supersedingOrder = 7;
      newBread.Order = supersedingOrder;
      Assert.AreEqual(supersedingOrder, newBread.Order);
    }

    [TestMethod]
    public void GetTotalPrice_GetsTotalPrice_Void()
    {
      Bread newBread = new();
      int expectedTotalPrice = 0;
      Assert.AreEqual(expectedTotalPrice, newBread.TotalPrice);
    }

    [TestMethod]
    public void SetTotalPrice_SetsTotalPrice_Void()
    {
      Bread newBread = new();
      newBread.CalcPrice(3);
      int supersedingTotalPrice = 100;
      newBread.TotalPrice = supersedingTotalPrice;
      Assert.AreEqual(supersedingTotalPrice, newBread.TotalPrice);
    }

    [TestMethod]
    public void CalcBreadPrice_CalculatesTotalPriceOfOrderWithoutDiscount_Void()
    {
      Bread newBread = new();
      int newOrder = 1;
      newBread.CalcPrice(newOrder);
      int expectedTotalPrice = 5;
      Assert.AreEqual(expectedTotalPrice, newBread.TotalPrice);
    }

    [TestMethod]
    public void CalcBreadPrice_CalculatesTotalPriceOfOrderWithDiscount_Void()
    {
      Bread newBread = new();
      int newOrder = 3;
      newBread.CalcPrice(newOrder);
      int expectedTotalPrice = 10;
      Assert.AreEqual(expectedTotalPrice, newBread.TotalPrice);
    }
  }
}
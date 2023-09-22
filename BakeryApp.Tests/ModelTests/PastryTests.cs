using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System.Reflection.Metadata;
using System;

namespace BakeryApp.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void GetOrder_GetsOrder_Void()
    {
      Pastry newPastry = new();
      int newOrder = 6;
      newPastry.CalcPrice(newOrder);
      Assert.AreEqual(newOrder, newPastry.Order);
    }

    [TestMethod]
    public void SetOrder_SetsOrder_Void()
    {
      Pastry newPastry = new();
      newPastry.CalcPrice(3);
      int supersedingOrder = 7;
      newPastry.Order = supersedingOrder;
      Assert.AreEqual(supersedingOrder, newPastry.Order);
    }

    [TestMethod]
    public void GetTotalPrice_GetsTotalPrice_Void()
    {
      Pastry newPastry = new();
      int expectedTotalPrice = 0;
      Assert.AreEqual(expectedTotalPrice, newPastry.TotalPrice);
    }

    [TestMethod]
    public void SetTotalPrice_SetsTotalPrice_Void()
    {
      Pastry newPastry = new();
      newPastry.CalcPrice(3);
      int supersedingTotalPrice = 100;
      newPastry.TotalPrice = supersedingTotalPrice;
      Assert.AreEqual(supersedingTotalPrice, newPastry.TotalPrice);
    }

    [TestMethod]
    public void CalcPastryPrice_CalculatesTotalPriceOfOrderWithoutDiscount_Void()
    {
      Pastry newPastry = new();
      int newOrder = 1;
      newPastry.CalcPrice(newOrder);
      int expectedTotalPrice = 2;
      Assert.AreEqual(expectedTotalPrice, newPastry.TotalPrice);
    }

    [TestMethod]
    public void CalcPastryPrice_CalculatesTotalPriceOfOrderWithDiscount_Void()
    {
      Pastry newPastry = new();
      int newOrder = 4;
      newPastry.CalcPrice(newOrder);
      int expectedTotalPrice = 6;
      Assert.AreEqual(expectedTotalPrice, newPastry.TotalPrice);
    }
  }
}
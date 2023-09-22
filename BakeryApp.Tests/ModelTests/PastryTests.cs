using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System.Reflection.Metadata;
using System;

namespace BakeryApp.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.CalcPastryPrice(0);
    }

    [TestMethod]
    public void GetOrder_GetsOrder_Void()
    {
      int newOrder = 6;
      Pastry.CalcPastryPrice(newOrder);
      Assert.AreEqual(newOrder, Pastry.Order);
    }

    [TestMethod]
    public void SetOrder_SetsOrder_Void()
    {
      Pastry.CalcPastryPrice(3);
      int supersedingOrder = 7;
      Pastry.Order = supersedingOrder;
      Assert.AreEqual(supersedingOrder, Pastry.Order);
    }

    [TestMethod]
    public void GetTotalPrice_GetsTotalPrice_Void()
    {
      int expectedTotalPrice = 0;
      Assert.AreEqual(expectedTotalPrice, Pastry.TotalPrice);
    }

    [TestMethod]
    public void SetTotalPrice_SetsTotalPrice_Void()
    {
      Pastry.CalcPastryPrice(3);
      int supersedingTotalPrice = 100;
      Pastry.TotalPrice = supersedingTotalPrice;
      Assert.AreEqual(supersedingTotalPrice, Pastry.TotalPrice);
    }

    [TestMethod]
    public void CalcPastryPrice_CalculatesTotalPriceOfOrderWithoutDiscount_Void()
    {
      int newOrder = 1;
      Pastry.CalcPastryPrice(newOrder);
      int expectedTotalPrice = 2;
      Assert.AreEqual(expectedTotalPrice, Pastry.TotalPrice);
    }

    [TestMethod]
    public void CalcPastryPrice_CalculatesTotalPriceOfOrderWithDiscount_Void()
    {
      int newOrder = 4;
      Pastry.CalcPastryPrice(newOrder);
      int expectedTotalPrice = 6;
      Assert.AreEqual(expectedTotalPrice, Pastry.TotalPrice);
    }
  }
}
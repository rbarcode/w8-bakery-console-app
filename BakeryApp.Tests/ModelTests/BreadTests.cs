using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System.Reflection.Metadata;
using System;

namespace BakeryApp.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.CalcBreadPrice(0);
    }

    [TestMethod]
    public void GetOrder_GetsOrder_Void()
    {
      int newOrder = 6;
      Bread.CalcBreadPrice(newOrder);
      Assert.AreEqual(newOrder, Bread.Order);
    }

    [TestMethod]
    public void SetOrder_SetsOrder_Void()
    {
      Bread.CalcBreadPrice(3);
      int supersedingOrder = 7;
      Bread.Order = supersedingOrder;
      Assert.AreEqual(supersedingOrder, Bread.Order);
    }

    [TestMethod]
    public void GetTotalPrice_GetsTotalPrice_Void()
    {
      int expectedTotalPrice = 0;
      Assert.AreEqual(expectedTotalPrice, Bread.TotalPrice);
    }

    [TestMethod]
    public void SetTotalPrice_SetsTotalPrice_Void()
    {
      Bread.CalcBreadPrice(3);
      int supersedingTotalPrice = 100;
      Bread.TotalPrice = supersedingTotalPrice;
      Assert.AreEqual(supersedingTotalPrice, Bread.TotalPrice);
    }

    [TestMethod]
    public void CalcBreadPrice_CalculatesTotalPriceOfOrderWithoutDiscount_Void()
    {
      int newOrder = 1;
      Bread.CalcBreadPrice(newOrder);
      int expectedTotalPrice = 5;
      Assert.AreEqual(expectedTotalPrice, Bread.TotalPrice);
    }

    [TestMethod]
    public void CalcBreadPrice_CalculatesTotalPriceOfOrderWithDiscount_Void()
    {
      int newOrder = 3;
      Bread.CalcBreadPrice(newOrder);
      int expectedTotalPrice = 10;
      Assert.AreEqual(expectedTotalPrice, Bread.TotalPrice);
    }
  }
}
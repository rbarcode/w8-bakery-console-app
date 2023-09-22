using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;
using System.Reflection.Metadata;

namespace BakeryApp.Tests
{
  [TestClass]
  public class BreadTests

  {
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
      int newOrder = 0;
      Bread.CalcBreadPrice(newOrder);
      Assert.AreEqual(0, Bread.TotalPrice);
    }
  }
}
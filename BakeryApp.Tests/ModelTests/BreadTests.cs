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
      int supercedingOrder = 7;
      Bread.Order = supercedingOrder;
      Assert.AreEqual(supercedingOrder, Bread.Order);
    }
  }
}
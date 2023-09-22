using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryApp.Models;

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
  }
}
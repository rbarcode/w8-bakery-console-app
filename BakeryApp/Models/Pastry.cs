using System;

namespace BakeryApp.Models
{
  public class Pastry
  {
    private static int _price = 2;
    private static int _everyFourthOrder = 4;
    public static int Order { get; set; }
    public static int TotalPrice { get; set; }

    public static void CalcPastryPrice(int order)
    {
      Order = order;
      TotalPrice = (Order * _price);
      if (Order / _everyFourthOrder >= 1)
      {
        TotalPrice -= ((Order / _everyFourthOrder) * _price);
      }
    }
  }
}
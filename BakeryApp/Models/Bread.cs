using System;
using System.Runtime.CompilerServices;

namespace BakeryApp.Models
{
  public class Bread : BakedGoods
  {
    new private int _price = 5;
    new private int _discountOnEveryNthOrder = 3;
    public override int Order { get; set; }
    public override int TotalPrice { get; set; }

    public Bread() { }

    public override void CalcPrice(int order)
    {
      Order = order;
      TotalPrice = (Order * _price);
      if (Order / _discountOnEveryNthOrder >= 1)
      {
        TotalPrice -= ((Order / _discountOnEveryNthOrder) * _price);
      }
    }
  }
}
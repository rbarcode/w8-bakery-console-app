using System;

namespace BakeryApp.Models
{
  public class Pastry : BakedGoods
  {
    new private int _price = 2;
    new private int _discountOnEveryNthOrder = 4;
    public override int Order { get; set; }
    public override int TotalPrice { get; set; }

    public Pastry() {}

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
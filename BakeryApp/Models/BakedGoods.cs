using System;

namespace BakeryApp.Models
{

  public abstract class BakedGoods
  {
    private protected int _price;
    private protected int _discountOnEveryNthOrder;
    public abstract int Order { get; set; }
    public abstract int TotalPrice { get; set; }

    public void CalcPrice(int order)
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
using System;

namespace BakeryApp.Models
{

  public abstract class BakedGoods
  {
    private protected int _price;
    private protected int _discountOnEveryNthOrder;
    public abstract int Order { get; set; }
    public abstract int TotalPrice { get; set; }

    public abstract void CalcPrice(int order);
  }
}
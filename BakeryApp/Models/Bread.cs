using System.Runtime.CompilerServices;

namespace BakeryApp.Models
{
  public class Bread
  {
    private static int _price = 5;
    private static int _everyThirdOrder = 3;
    public static int Order { get; set; }
    public static int TotalPrice { get; set; }

    public static void CalcBreadPrice(int order)
    {
      Order = order;
      TotalPrice = (Order * _price);
      if (Order % _everyThirdOrder == 0)
      {
        TotalPrice -= ((Order / _everyThirdOrder) * _price);
      }
    }
  }
}
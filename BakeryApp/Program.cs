using System;
using BakeryApp.Models;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the Bakery App!");
      Console.WriteLine("Please enter the number of loaves of bread you would like to buy.");
      string stringBreadNumber = Console.ReadLine();
      int breadOrder = int.Parse(stringBreadNumber);
      Bread.CalcBreadPrice(breadOrder);
      Console.WriteLine($"Your total is: $" + Bread.TotalPrice);
    }
  }
}
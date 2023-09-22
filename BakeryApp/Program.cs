using System;
using BakeryApp.Models;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the Bakery App!");
      Console.WriteLine("A loaf of bread is $5.");
      Console.WriteLine("We are currently running a special on our bread: Buy 2, Get 1 free!");
      Console.WriteLine("A single pastry is $2.");
      Console.WriteLine("We are currently running a special on our pastries: Buy 3, Get 1 free!");
      Console.WriteLine("Please enter the number of loaves of bread you would like to buy.");
      string stringBreadNumber = Console.ReadLine();
      int breadOrder = int.Parse(stringBreadNumber);
      Console.WriteLine("Please enter the number of pastries you would like to buy.");
      string stringPastryNumber = Console.ReadLine();
      int pastryOrder = int.Parse(stringPastryNumber);
      Bread.CalcBreadPrice(breadOrder);
      Pastry.CalcPastryPrice(pastryOrder);
      Console.WriteLine($"Your total is: $" + (Bread.TotalPrice + Pastry.TotalPrice) + ".");
    }
  }
}
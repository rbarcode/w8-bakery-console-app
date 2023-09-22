using System;
using BakeryApp.Models;

namespace BakeryApp
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("A loaf of bread is $5.");
      Console.WriteLine("We are currently running a special on our bread: Buy 2, Get 1 free!");
      Console.WriteLine("A single pastry is $2.");
      Console.WriteLine("We are currently running a special on our pastries: Buy 3, Get 1 free!");
      SolicitAndVerifyInput();
    }

    static void SolicitAndVerifyInput()
    {
      Console.WriteLine("Please enter the number of loaves of bread you would like to buy.");
      string stringBreadNumber = Console.ReadLine();
      bool breadIsNumerical = int.TryParse(stringBreadNumber, out int breadOrder);
      if (!breadIsNumerical)
      {
        Console.WriteLine($"I'm sorry, '{stringBreadNumber}' is not an integer. Please start over and submit a new order.");
        SolicitAndVerifyInput();
      }
      else
      {
        Console.WriteLine("Please enter the number of pastries you would like to buy.");
        string stringPastryNumber = Console.ReadLine();
        bool pastryIsNumerical = int.TryParse(stringPastryNumber, out int pastryOrder);
        if (!pastryIsNumerical)
        {
          Console.WriteLine($"I'm sorry, '{stringPastryNumber}' is not an integer. Please start over and submit a new order.");
          SolicitAndVerifyInput();
        }
        else if (breadOrder == 0 && pastryOrder == 0)
        {
          Console.WriteLine("Please come back when you would like to place an order. Goodbye!");
        }
        else
        {
          RunPriceCalc(breadOrder, pastryOrder);
        }
      }
    }

    static void RunPriceCalc(int bread, int pastry)
    {
      Bread newBread = new();
      Pastry newPastry = new();
      newBread.CalcPrice(bread);
      newPastry.CalcPrice(pastry);
      Console.WriteLine($"Your total is: $" + (newBread.TotalPrice + newPastry.TotalPrice) + ".");
      QueryNewOrder();
    }

    static void QueryNewOrder()
    {
      Console.WriteLine("Would you like to purchase more baked goods?");
      Console.WriteLine("Please enter 'yes' to buy more bread and/or pastries. To exit, enter any key.");
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "yes")
      {
        SolicitAndVerifyInput();
      }
      else
      {
        Console.WriteLine("Bon Appetit! Come back again for more fresh bread and pastries!");
      }
    }
  }
}
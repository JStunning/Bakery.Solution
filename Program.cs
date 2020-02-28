using System;
using System.Collections.Generic;
using BreadBin.Models;
using PastryBin.Models;

public class Program
{

  public static Bread myBread;
  public static Pastry myPastry;
  public static void Main()
  {
    myBread = new Bread();
    myPastry = new Pastry();

    Console.WriteLine("What would you like to purchase?");
    Console.WriteLine("1 for Bread or 2 for Pastry");
    int userInput = int.Parse(Console.ReadLine());
    if(userInput == 1)
    {
      Console.WriteLine("What kind of bread do you want?");
      Console.WriteLine("White, Wheat, French Bread, etc...");
      string BreadType = Console.ReadLine();
      myBread.SetType(BreadType);
      Console.WriteLine("How many loaves you want?");
      int BreadNum = int.Parse(Console.ReadLine());
      myBread.SetLoafs(BreadNum);
      Console.WriteLine($"{myBread.Loaves} loaves of {myBread.Type} bread");
      Console.WriteLine($"${myBread.Price}, please.");
    }
    else 
    {
      Console.WriteLine("What kind of pastry do you want?");
      Console.WriteLine("Muffin, Donut, Turnover, Bearclaw, etc...");
      string PastryType = Console.ReadLine();
      myPastry.SetType(PastryType);
      Console.WriteLine($"How many {myPastry.Type}s you want?");
      var PastryNum = Console.ReadLine();
      Console.WriteLine(PastryNum.GetType());
      // if(PastryNum.GetType() == System.Int)
      // {
          //myPastry.SetGoods(PastryNum);
      // }
      //myPastry.SetGoods(PastryNum);
      Console.WriteLine($"{myPastry.Goods} {myPastry.Type}s");
      Console.WriteLine($"${myPastry.Price}, please.");
    }

  }

}

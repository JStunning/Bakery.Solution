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
      Console.WriteLine("How many loaves you want?");
      int BreadNum = int.Parse(Console.ReadLine());
      myBread.SetLoafs(BreadNum);
      Console.WriteLine(myBread.Price);
    }
    else 
    {
      Console.WriteLine("How many goods you want?");
      int PastryNum = int.Parse(Console.ReadLine());
      myPastry.SetGoods(PastryNum);
      Console.WriteLine(myPastry.Price);
    }

  }

}

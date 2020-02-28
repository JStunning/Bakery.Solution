using System;
using System.Collections.Generic;

namespace PastryBin.Models
{
    public class Pastry
    {
      public int Price { get; set; }
      public int Goods { get; set; }
      public string Type { get; set; }

      public Pastry()
      {
        Price = 0;
        Goods = 0;
        Type = "No Type";
      }

      public void SetGoods(int goods)
      { 
        Goods = goods;
        isDeal();
      }

      public void isDeal()
      {
        if(Goods % 3 == 0)
        {
          Console.WriteLine("What a deal!");
          Price = 5 * (Goods / 3);
        }
        else 
        {
          Price *= Goods;          
        }
      }

      public void SetType(string type)
      {
        Type = type;
      }
    }
}
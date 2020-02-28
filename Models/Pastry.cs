using System;
using System.Collections.Generic;

namespace PastryBin.Models
{
    public class Pastry
    {
      public int Price { get; set; }
      public int Goods { get; set; }

      public Pastry()
      {
        Price = 0;
        Goods = 0;
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
          Price = 5;
        }
        else 
        {
          Price *= Goods;          
        }
      }
    }
}
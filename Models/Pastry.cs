using System;
using System.Collections.Generic;

namespace PastryBin.Models
{
    public class Pastry
    {
      public int Price { get; set; }
      public int Goods { get; set; }
      public string Type { get; set; }
      public bool IsDeal { get; set; }

      public Pastry()
      {
        Price = 2;
        Goods = 0;
        Type = "No Type";
        IsDeal = false;
      }

      public void SetGoods(int goods)
      {
        Goods = goods;
        SalePrice();
      }

      public void SalePrice()
      {
        if(Goods % 3 == 0)
        {
          Price = 5 * (Goods / 3);
          IsDeal = true;
        }
        else 
        {
          Price *= Goods;          
          IsDeal = false;
        }
      }

      public void SetType(string type)
      {
        Type = type;
      }
    }
}
using System;
using System.Collections.Generic;

namespace BreadBin.Models
{
    public class Bread
    {
      public int Price { get; set; }

      public int Loaves { get; set; }

      public string Type { get; set; }

      public bool IsDeal { get; set; }


      public Bread()
      {
        Price = 5;
        Loaves = 0;
        Type = "No Type";
        IsDeal = false;
      }

      public void SetLoaves(int loaves)
      { 
        Loaves = loaves;
        SalePrice();
      }

      public void SalePrice()
      {
        if(Loaves % 2 == 0)
        {
          Price = 5 * (Loaves / 2);
          IsDeal = true;
        }
        else 
        {
          Price *= Loaves;    
          IsDeal = false;
        }
      }

      public void SetType(string type)
      {
        Type = type;
      }
    }
}
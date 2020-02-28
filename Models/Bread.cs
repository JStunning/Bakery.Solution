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
      }

      public void SetLoafs(int loaves)
      { 
        Loaves = loaves;
        isDeal();
      }

      public void SalePrice()
      {
        if(Loaves % 2 == 0)
        {
          Console.WriteLine("is Deal!");
          Price = 5 * (Loaves / 2);
        }
        else 
        {
          Price *= Loaves;          
        }
      }

      public void SetType(string type)
      {
        Type = type;
      }
    }
}
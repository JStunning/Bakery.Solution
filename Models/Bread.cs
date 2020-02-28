using System;
using System.Collections.Generic;

namespace BreadBin.Models
{
    public class Bread
    {
      public int Price { get; set; }
      public int Loaves { get; set; }

      public string Type { get; set; }

      public Bread()
      {
        Price = 5;
        Loaves = 0;
        Type = "No Type";
      }

      public void SetLoafs(int loafs)
      { 
        Loaves = loafs;
        isDeal();
      }

      public void isDeal()
      {
        if(Loaves % 2 == 0)
        {
          Console.WriteLine("What a deal!");
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
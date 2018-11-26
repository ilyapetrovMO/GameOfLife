using System;
using System.Collections.Generic;
using System.Linq;

namespace Gameoflife
{
   public class Point
    {
          public Point(int x, int y)
        {
            this.grid_X=x;
            this.grid_Y=y;
        }

       private int grid_X;
       public int Grid_X
       {
           get { return grid_X;}
           set { grid_X = value;}
       }
       
       private int grid_Y;
       public int Grid_Y
       {
           get { return grid_Y;}
           set { grid_Y = value;}
       }
       
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Point> Points = new List<Point>();
             for (int i = 0; i < 10; i++)
             {
                 Points.Add(new Point(1,i));
             }
            
             foreach (var item in Points)
             {
                 System.Console.WriteLine("{0} {1}",item.Grid_X,item.Grid_Y);
             }
           }
    }
}
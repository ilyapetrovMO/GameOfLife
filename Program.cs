using System;
using System.Collections.Generic;
using System.Linq;

namespace Gameoflife
{
   public class Point
    {      
        private int grid_X;
        private int grid_Y;
        private bool state;

                  public Point(int x, int y, bool state)
        {
            this.grid_X = x;
            this.grid_Y = y;
            this.state  = state;
        }

        public bool State
        {
            get { return state;}
            set { state = value;}
        }

       public int Grid_X
       {
           get { return grid_X;}
           set { grid_X = value;}
       }   
              public int Grid_Y
       {
           get { return grid_Y;}
           set { grid_Y = value;}
       }

       public static bool RandomState()
        {
            bool state;
            Random rnd = new Random();
            return  state = Convert.ToBoolean(rnd.Next(0,3));           
        }
        
    }
    class Program
    {
        const int size_X =20;
        const int size_Y=20;
        static List<Point> Evo1 = new List<Point>();
        static List<Point> Evo2 = new List<Point>();
        static void Main(string[] args)
        {   
            FillRandom(Evo1);
            WriteList(Evo1);
        }

        private static void WriteList (List<Point> List)
        {
             foreach (var item in List)
             {
                 char state_char;
                 if (item.State == true) {state_char = '#';}else {state_char = ' ';} 
                 System.Console.Write(" {0} ",state_char);
                 if (item.Grid_X==20){System.Console.WriteLine();}
             }
        }

        private static void FillRandom (List<Point> List)
        {
             for (int i = 0; i <= size_X; i++)
             {
                 for (int j = 0; j <= size_Y; j++)
                    {
                        Evo1.Add(new Point(j,i,Point.RandomState()));
                    }
             }
        }


    }
    class Logic
    {
        public static void NewState(List<Point> List)
        {
            foreach (var item in List)
            {
                if (item.Grid_X==0 && item.Grid_Y==0)
            }
        }
    }
}
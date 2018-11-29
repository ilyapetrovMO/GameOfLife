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

        public static bool StateCheck(int switch_on,int X,int Y,List<Point> Evo1){
            int count=0;
            switch (switch_on)
            {
                //if x=0 and y=0
                case 0: if(Evo1.Exists(c => c.Grid_X==1 && c.Grid_Y==0 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==1 && c.Grid_Y==1 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==0 && c.Grid_Y==1 && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if {x+1 ... size_X-1} and y=0
                case 1: if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==0 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==1 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==(Y+1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y+1) && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if x=size_X and y=0
                case 2: if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==0 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==1 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==1 && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if x=0 and {y+1 ... size_Y-1}
                case 3: if(Evo1.Exists(c => c.Grid_X==0 && c.Grid_Y==Y-1 && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==Y && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==(Y+1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y+1) && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if x=size_X and {y+1 ... size_Y-1}
                case 4: if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==Y && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y+1) && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if x=0 and y=size_Y
                case 5: if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==Y && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if {x+1 ... size_X-1} and y=size_Y
                case 6: if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==Y && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X+1) && c.Grid_Y==Y && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //if x=size_X and y=0
                case 7: if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==Y && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==(X-1) && c.Grid_Y==(Y-1) && c.State)){count++;}
                        if (count>=3){return true;}else{return false;}
                        
                //all other points
                case 8: if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y-1))){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X+1 && c.Grid_Y==(Y-1))){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X+1 && c.Grid_Y==Y)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X+1 && c.Grid_Y==(Y+1))){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X && c.Grid_Y==(Y+1))){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X-1 && c.Grid_Y==(Y+1))){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X-1 && c.Grid_Y==Y)){count++;}
                        if(Evo1.Exists(c => c.Grid_X==X-1 && c.Grid_Y==(Y-1))){count++;}
                        if(count>=3){return true;}else{return false;}
                        
                default: return false;
                       
            }
        }
        
    }
    class Program
    {
        public const int size_X =20;
        public const int size_Y=20;
        static List<Point> Evo1 = new List<Point>();
        static List<Point> Evo2 = new List<Point>();
        static void Main(string[] args)
        {   
            FillRandom(Evo1);
            FillZero(Evo2);
            
            NewState();
            WriteList(Evo1);
            NewState();
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

        private static void FillZero (List<Point> List)
        {
            foreach (var item in List){
                item.Grid_X=0;
                item.Grid_Y=0;
                item.State=false;
            }
        }
        public static void NewState()
        {
            for (int i = 0; i < size_X; i++)
            {
                for (int j = 0; i < size_Y; j++)
                {
                    if(j==0 && i==0)
                    { 
                        if(Point.StateCheck(0,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                        
                    }
                    else if (j>0 && j<size_X && i==0)
                    {
                        if(Point.StateCheck(1,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else if (j==size_X && i==0)
                    {
                        if(Point.StateCheck(2,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else if (j==0 && i>1 && i<size_Y)
                    {
                        if(Point.StateCheck(3,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else if (j==size_X && i>1 && i<size_Y)
                    {
                        if(Point.StateCheck(4,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else if (j==0 && i==size_Y)
                    {
                        if(Point.StateCheck(5,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else if (j>1 && j<size_X && i==0)
                    {
                        if(Point.StateCheck(6,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else if (j==size_X && i==size_Y)
                    {
                        if(Point.StateCheck(7,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }
                    else
                    {
                        if(Point.StateCheck(8,j,i,Evo1)){
                            var result = Evo2.Find( c=> c.Grid_X==j && c.Grid_Y==i);
                            result.State=true;
                        }
                    }

                    Evo1=Evo2;
                    Evo2.Clear();
                }
            }
        }
    }
}
using System;

namespace pattern_star
{
    class Program
    {
       static void Main(string[] args)
       {
   
          for (int i=1;i<=3;i++)
          {
            for (int j=1;j<=i;j++)
            {
               Console.Write("*");
            }
                Console.WriteLine();
          }
                for (int i=1;i<=5;i++)
                {
                   for(int j=1;j<=i;j++)
                    {
                        Console.Write("*");
                    }
                      Console.WriteLine();
                } 
       }
    } 
       
}

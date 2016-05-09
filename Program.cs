using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortanCSharp
{
    class Program
    {


        static int BubbleSort()
        {
            
            Console.Write("\n\nEnter number of Elements: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());
 
            int [] numArray = new int[maxNum];
 
            for(int a = 0; a < maxNum; a++)
            {
                Console.Write("\nEnter Number" + (a + 1).ToString()+"   " );
                numArray[a] = Convert.ToInt32(Console.ReadLine());
            }
 
        
 
            for(int a = 1; a < maxNum; a++)
            {
                for(int b = 0; b < maxNum - a; b++)
                {
                    if(numArray[b] > numArray[b + 1])
                    {
                        int temp = numArray[b];
                        numArray[b] = numArray[b + 1];
                        numArray[b + 1] = temp;
                    }
                }
                
            }
 
            Console.Write("\n\n Ascending Order:\n\n");
            for(int a = 0; a < maxNum; a++)
            {
               
                Console.Write(numArray[a]);
                Console.Write("\n");
            }
            return 0;
        }  
 
      static void Main(string[] args)
      {
            BubbleSort();
            Console.ReadKey();
           
      }
    }

    }

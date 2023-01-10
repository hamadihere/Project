using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = {10, 20, 5, 55, 122, 67};
            int a = 0;
            int i = 0;

            Console.WriteLine("Enter Number To Search: ");
            int b = Convert.ToInt32(Console.ReadLine());

           
           for ( i = 0; i < Arr.Length; i++) {

                if (b == Arr[i]) {

                    a = 1;
                    break;
               
                }


            
            }


           if (a == 1)
           {

               Console.WriteLine("Found At Location " + i);
           }
           else {

               Console.WriteLine("Not Found!");
           }
            
            

        }
    }
}

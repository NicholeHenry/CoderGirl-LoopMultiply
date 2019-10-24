using System;
using System.Collections;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            //int[] loopNumbers ={2,3,4,5,6,7,8,9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,20};
            ArrayList results = new ArrayList();
            for (int i = 2; i < 21; i++)
            {


                Console.WriteLine("please enter a number");
                int userNumber = int.Parse(Console.ReadLine());
                var result = i * userNumber;
                Console.WriteLine(result);
                
                results.Add(result);
               
            }
            int sum = 0;
            int[] finalResults = (int[])results.ToArray(typeof(int));
            for (int i = 0; i < results.Count; i++)
            {
                sum += finalResults[i];
            }
           Console.WriteLine(sum);
            Console.ReadLine();                                   

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 

            // TODO: When the loop is finished, output the sum of all previous values.

           
        }
    }
}

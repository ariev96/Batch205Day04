using System;
using System.Collections.Generic;
using System.Linq;

namespace caCompareTheTriplets
{
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bobi = 0;
            
            for (int i = 0; i < 4; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if(a[i] < b[i])
                {
                    bobi++;
                }
                else
                {
                    alice += 0;
                    bobi += 0;
                }
            }

            //hasil = ""+alice.ToString() + bobi.ToString()+"";
            return a;
            

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

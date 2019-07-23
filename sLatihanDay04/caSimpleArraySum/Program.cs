using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSimpleArraySum
{
    class Program
    {
        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            int hasil = 0;
             
            for (int i = 0; i < ar.Length; i++)
            {

                hasil = ar[i] + hasil;
                 
            }

            return hasil;

        }

        static void Main(string[] args)
        {

            //int arCount = Convert.ToInt32(Console.ReadLine());
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            Console.WriteLine("Masukan panjang deret:");
            int arCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input angka:");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = simpleArraySum(ar);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

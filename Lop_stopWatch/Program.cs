using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_stopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int min, index, gan;
            Random rd = new Random();
                        int[] arr = new int[100000];
           
            for (int i = 0; i<arr.Length; i++ )
            {
                arr[i] = (int)rd.Next();
            }
           
           
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {


                    if (arr[j] < min)
                    {

                        min = arr[j];
                        index = j;
                        gan = arr[i];
                        arr[i] = arr[index];
                        arr[index] = gan;

                    }
                }
                Console.Write(arr[i] + " ");

            }
            sw.Stop();
            Console.Write("\n \n ************************************************\n thoi gian chay la: " + sw.GetElapsedTime());
            Console.ReadKey();

        }
    }
}
#endregion

  
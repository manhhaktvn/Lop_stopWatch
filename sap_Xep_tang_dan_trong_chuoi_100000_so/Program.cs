using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace sap_Xep_tang_dan_trong_chuoi_100000_so
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] arr = new int[5] { 4, 3, 5, 2, -5 };
            int min, index, gan;
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
            Console.ReadKey();

        }
    }
}
#endregion



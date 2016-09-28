using System;

namespace BestOfBrands.tenta
{
    public class Exercise1
    {
        public void GetEvenNumbers()
        {
            int[] array = new int[100];
            int number = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;

                if (i%2 == 0)
                {
                    number += i;
                    count++;
                }
            }

            Console.WriteLine(number/count);
        }
    }
}
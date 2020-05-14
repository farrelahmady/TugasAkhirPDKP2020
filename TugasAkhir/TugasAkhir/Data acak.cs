using System;
using System.Collections.Generic;
using System.Text;

namespace Questioner
{
    public class Data_acak
    {

        public int[] data()
        {
            int x;

            int[] angka = new int[10];

            Random num = new Random();


            angka[0] = num.Next(1,11);
            for (int i = 1; i < 10; i++)
            {
                x = num.Next(1, 11);
                for (int j = 0; j < 10; j++)
                {
                    if (x == angka[j])
                    {
                        x = num.Next(1, 11);
                        j = -1;
                    }
                }
                angka[i] = x;
            }
            return angka;


        }
    }
}

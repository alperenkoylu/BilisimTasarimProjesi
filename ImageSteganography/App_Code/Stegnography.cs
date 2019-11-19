using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageSteganography.App_Code
{
    public class Stegnography
    {
        static readonly char EOM = ';';
        
        struct Piksel
        {
            public int Value, LastBit;
            public int[] BinaryValue;

            public Piksel(int value)
            {
                Value = value;
                BinaryValue = Array.ConvertAll(Convert.ToString(value, 2).PadLeft(8, '0').ToCharArray(), w => (int)Char.GetNumericValue(w));
                LastBit = BinaryValue[7];
            }

            public void WriteMessage(int i)
            {
                if (LastBit != i)
                {
                    LastBit = i;
                    BinaryValue[7] = LastBit;
                    //Value = (i == 0) ? Value-- : Value++;
                    Value = 0;
                    for (int j = 0; j < 8; j++)
                        Value += Convert.ToInt32(BinaryValue[j] * Math.Pow(2, 7 - j));
                }
            }
        }

        static string DecodeMessage(int w, int h, Piksel[,] p)
        {
            int k = 0;
            char c;
            string temp = "", ret = "";

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    temp += p[i, j].LastBit;
                    if (k == 7)
                    {
                        c = (char)Convert.ToInt32(temp, 2);
                        if (c == EOM)
                            return ret;
                        ret += c;
                        temp = "";
                        k = 0;
                    }
                    else k++;
                }
            }

            return ret;
        }

        static int[] EncodeMessage(string s)
        {
            int k = 0;
            int[,] a = new int[s.Length, 8];
            int[] temp;
            foreach (var item in s.ToCharArray())
            {
                temp = Array.ConvertAll(Convert.ToString((int)item, 2).PadLeft(8, '0').ToCharArray(), w => (int)Char.GetNumericValue(w));

                for (int j = 0; j < 8; j++) a[k, j] = temp[j];

                k++;
            }

            int[] ret = new int[a.Length];
            k = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    ret[k] = a[i, j];
                    k++;
                }
            }

            return ret;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageStego
{
    class Program
    {
        struct Piksel
        {
            public int X, Y, Value, LastBit;
            public int[] BinaryValue;

            public Piksel(int x, int y, int value)
            {
                X = x;
                Y = y;
                Value = value;
                BinaryValue = Array.ConvertAll(Convert.ToString(value, 2).PadLeft(8, '0').ToCharArray(), w => (int)Char.GetNumericValue(w));
                LastBit = BinaryValue[7];
            }

            public void WriteMessage(int i)
            {
                LastBit = i;
                BinaryValue[7] = LastBit;
                Value = 0;
                for (int j = 0; j < 8; j++)
                    Value += Convert.ToInt32(BinaryValue[j] * Math.Pow(2, 7 - j));
            }
        }

        static int[] TurnMessageIntoBinary(string s)
        {
            int[] a = new int[s.Length * 8];


            return a;
        }

        static void Main(string[] args)
        {
            //string filename = "lenna.bmp";
            //Bitmap original_bmp = new Bitmap(".\\cover-images\\" + filename);
            //int width = original_bmp.Width, height = original_bmp.Height;
            //Piksel[,] pArr = new Piksel[width, height];

            //for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) pArr[i, j] = new Piksel(i, j, original_bmp.GetPixel(i, j).R);
            
            //Console.Write("Enter Message: ");
            //string s = Console.ReadLine();

            //int[] message = TurnMessageIntoBinary(s);

            Console.ReadKey();
        }
    }
}

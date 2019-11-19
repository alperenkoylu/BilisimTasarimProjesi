using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageStego
{
    class Program
    {
        static readonly char EOM = ';';

        static readonly string[] filenames = { "airplane.bmp", "baboon.bmp", "dollar.bmp", "finger.bmp", "lenna.bmp", "pepper.bmp", "tiffany.bmp" };

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

        private static void WriteMessage(int selection, int width, int height, Bitmap bmp, Piksel[,] p, int[] message)
        {
            int mLength = message.Length;

            int k = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (k < mLength)
                        p[i, j].WriteMessage(message[k]);
                    else
                        break;
                    k++;
                }
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(p[i, j].Value, p[i, j].Value, p[i, j].Value));
                }
            }

            bmp.Save(".\\stego-images\\" + filenames[selection - 1]);
        }

        static double CalculateCapacity(int msgLen, int width, int height)
        {
            double numerator = msgLen * 8;
            double denominator = width * height;

            return numerator / denominator;
        }

        static double CalculateMSE(Piksel[,] p_Stego, Piksel[,] p_Cover, int width, int height)
        {
            double numerator = 0;
            double denominator = width * height;
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    numerator += Math.Pow((p_Cover[i, j].Value - p_Stego[i, j].Value), 2);

            return numerator / denominator;
        }

        static double CalculatePSNR(Piksel[,] p_Stego, Piksel[,] p_Cover, int width, int height)
        {
            double numerator = Math.Pow(255, 2);
            double denominator = CalculateMSE(p_Stego, p_Cover, width, height);

            return 10 * Math.Log10(numerator / denominator);
        }

        static double CalculateSSIM(Piksel[,] p_Stego, Piksel[,] p_Cover, int width, int height, int msgLen)
        {
            double k1 = 0.01;
            double k2 = 0.03;
            double L = Math.Pow(2, CalculateCapacity(msgLen, width, height)) - 1;
            double c1 = Math.Pow(k1 * L, 2);
            double c2 = Math.Pow(k2 * L, 2);
            double n = width * height;

            double SumOf_EachX = 0;
            double MeanX = 0;
            for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) SumOf_EachX += p_Stego[i, j].Value;
            MeanX = SumOf_EachX / n;

            double SumOf_EachY = 0;
            double MeanY = 0;
            for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) SumOf_EachY += p_Cover[i, j].Value;
            MeanY = SumOf_EachY / n;

            double SumOf_EachX_Diff_MeanX = 0;
            for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) SumOf_EachX_Diff_MeanX = p_Stego[i, j].Value - MeanX;
            double variance_X = Math.Pow(SumOf_EachX_Diff_MeanX, 2) / n - 1;

            double SumOf_EachY_Diff_MeanY = 0;
            for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) SumOf_EachY_Diff_MeanY = p_Cover[i, j].Value - MeanY;
            double variance_Y = Math.Pow(SumOf_EachY_Diff_MeanY, 2) / n - 1;

            double SumOf_EachX_Diff_MeanX_Times_EachY_Diff_MeanY = 0;
            for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) SumOf_EachX_Diff_MeanX_Times_EachY_Diff_MeanY = (p_Stego[i, j].Value - MeanX) * (p_Cover[i, j].Value - MeanY);
            double covariance = SumOf_EachX_Diff_MeanX_Times_EachY_Diff_MeanY / n - 1;

            double numerator = (2 * MeanX * MeanY + c1) * (2 * covariance + c2);
            double denominator = (Math.Pow(MeanX, 2) + Math.Pow(MeanY, 2) + c1) * (variance_X + variance_Y + c2);

            return numerator / denominator;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < filenames.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, filenames[i]);
            }
            Console.Write("Select a cover image from list up above: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            Bitmap original_bmp = new Bitmap(".\\cover-images\\" + filenames[selection - 1]);
            int width = original_bmp.Width, height = original_bmp.Height, totalArea = width * height;
            Bitmap stego_image = new Bitmap(width, height);
            Piksel[,] pArr_original = new Piksel[width, height];
            Piksel[,] pArr = new Piksel[width, height];

            for (int i = 0; i < width; i++) for (int j = 0; j < height; j++) pArr_original[i, j] = pArr[i, j] = new Piksel(original_bmp.GetPixel(i, j).R);

            //Random R = new Random(totalArea);
            //HashSet<Piksel> hashP = new HashSet<Piksel>();

            //while (hashP.Count != totalArea)
            //{
            //    int rndWi = R.Next(0, width);
            //    int rndHe = R.Next(0, height);

            //    hashP.Add(pArr[rndWi, rndHe]);
            //}

            Console.WriteLine("\nDecoded Message:\n" + DecodeMessage(width, height, pArr)); //1011 1010

            Console.Write("\nEnter Message: ");
            string s = Console.ReadLine() + EOM;
            //string s = File.ReadAllText(@"message.txt") + EOM;

            int[] message = EncodeMessage(s);

            WriteMessage(selection, width, height, stego_image, pArr, message);

            Console.WriteLine("\nCapacity:\t\t\t{0} (bpp)", CalculateCapacity(message.Length, width, height).ToString());
            Console.WriteLine("Mean Square Error:\t\t{0} ", CalculateMSE(pArr, pArr_original, width, height).ToString());
            Console.WriteLine("Pixel Signal Noise Ratio:\t{0} (dB)", CalculatePSNR(pArr, pArr_original, width, height).ToString());
            Console.WriteLine("Structural Similarity Index:\t{0}", CalculateSSIM(pArr, pArr_original, width, height, message.Length).ToString());

            Console.WriteLine("Done!");

            Console.ReadKey();
        }
    }
}

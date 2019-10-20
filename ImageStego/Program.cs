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
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        static void Main(string[] args)
        {
            string filename = "lenna.bmp";
            Bitmap bmp = new Bitmap(".\\cover-images\\" + filename);

            int w = bmp.Width;
            int h = bmp.Height;

            int[,] PixelValue = new int[w, h];
            //int[,] Message = new int[w, h];
            string Message = "";

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    PixelValue[i, j] = bmp.GetPixel(i, j).R;
                    if (i == 0)
                        Message = string.Concat(Message, (PixelValue[i, j] % 2).ToString());
                }
            }

            Message = Message.Substring(0, 64);

            Console.WriteLine(BinaryToString(Message));

            Console.WriteLine("Completed !");

            Console.ReadKey();
        }
    }
}

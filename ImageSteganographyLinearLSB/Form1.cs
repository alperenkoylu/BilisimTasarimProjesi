using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSteganographyLinearLSB
{
    public partial class Form1 : Form
    {
        int w, h;

        int[,] message;
        double[,] pixelvalue;

        Bitmap original_bmp, stego_bmp, first_bmp, second_bmp, third_bmp, fourth_bmp, fifth_bmp, sixth_bmp, seventh_bmp, eighth_bmp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            openFileDialog.Filter = "Bitmap Only |*.bmp";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "cover-images";
        }

        private void ReadMessage(Bitmap bmp, int[,] m, double[,] pv)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    pv[i, j] = bmp.GetPixel(i, j).R;
                    m[i, j] = Convert.ToInt32(pixelvalue[i, j]) % 2;
                }
            }
        }

        public static string BinaryToString(int[,] msg, int wi, int he)
        {
            string data = "";

            for (int i = 0; i < wi; i++)
            {
                for (int j = 0; j < he; j++)
                {
                    if (i == 0)
                        data = string.Concat(data, msg[i, j].ToString());
                }
            }

            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private Bitmap LayerizeImage(int wi, int he, int layer_ratio)
        {
            Color c = new Color();
            Bitmap layered_bmp = new Bitmap(wi, he);
            double d = 0;
            int a;

            for (int i = 0; i < wi; i++)
            {
                for (int j = 0; j < he; j++)
                {
                    if (layer_ratio == 1) d = (pixelvalue[i, j] % 2) * 255;
                    else d = (Math.Floor(pixelvalue[i, j] / layer_ratio) % 2) * 255;

                    a = Convert.ToInt32(d);

                    c = Color.FromArgb(a, a, a);

                    layered_bmp.SetPixel(i, j, c);
                }
            }

            return layered_bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                original_bmp = new Bitmap(openFileDialog.FileName);

                w = original_bmp.Width;
                h = original_bmp.Height;

                pixelvalue = new double[w, h];
                message = new int[w, h];

                pbOriginal.Image = original_bmp;
                lblImageName.Text = openFileDialog.SafeFileName + "(" + w + "x" + h + ")";
                lblImageName.Visible = true;

                ReadMessage(original_bmp, message, pixelvalue);

                pbLayer1.Image = LayerizeImage(w, h, 1);
                pbLayer2.Image = LayerizeImage(w, h, 2);
                pbLayer3.Image = LayerizeImage(w, h, 4);
                pbLayer4.Image = LayerizeImage(w, h, 8);
                pbLayer5.Image = LayerizeImage(w, h, 16);
                pbLayer6.Image = LayerizeImage(w, h, 32);
                pbLayer7.Image = LayerizeImage(w, h, 64);
                pbLayer8.Image = LayerizeImage(w, h, 128);

                textBox1.Text = StringToBinary(BinaryToString(message, w, h));
            }
        }
    }
}

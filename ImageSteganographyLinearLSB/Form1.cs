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

        Bitmap original_bmp, first_bmp, second_bmp, third_bmp, fourth_bmp, fifth_bmp, sixth_bmp, seventh_bmp, eighth_bmp;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                for (int j = 0; j < h; j++)
                {
                    pv[i, j] = bmp.GetPixel(i, j).R;
                    m[i, j] = Convert.ToInt32(pixelvalue[i, j]) % 2;
                }
        }

        private void WriteMessage(Bitmap bmp, string s, double[,] pv)
        {
            char[] c = StringToBinary(s).ToCharArray();
            int k = c.Length, z = 0;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    if (z < k)
                    {

                    }
                    else break;
                    z++;
                }
            }



        }

        public static string BinaryToString(int[,] msg, int wi, int he)
        {
            string data = "";
            string eomCheck = "";
            int k = 0;
            for (int i = 0; i < wi; i++)
                for (int j = 0; j < he; j++)
                {
                    if (k % 8 == 0)
                    {
                        if (eomCheck == "00111011") break;
                        eomCheck = "";
                    }
                    data = string.Concat(data, msg[i, j].ToString());
                    eomCheck = string.Concat(eomCheck, msg[i, j].ToString());
                    k++;
                }

            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length - 8; i += 8)
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));

            return sb.ToString();
        }

        private Bitmap LayerizeImage(int wi, int he, int layer_number)
        {
            Color c = new Color();
            Bitmap layered_bmp = new Bitmap(wi, he);
            int a = 0;

            for (int i = 0; i < wi; i++)
                for (int j = 0; j < he; j++)
                {
                    if (layer_number == 1) a = Convert.ToInt32((pixelvalue[i, j] % 2) * 255);
                    else a = Convert.ToInt32((Math.Floor(pixelvalue[i, j] / Math.Pow(2, (layer_number - 1))) % 2) * 255);

                    c = Color.FromArgb(a, a, a);

                    layered_bmp.SetPixel(i, j, c);
                }

            return layered_bmp;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;

            pboxPreview.Image = pBox.Image;
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

                first_bmp = LayerizeImage(w, h, 1);
                second_bmp = LayerizeImage(w, h, 2);
                third_bmp = LayerizeImage(w, h, 3);
                fourth_bmp = LayerizeImage(w, h, 4);
                fifth_bmp = LayerizeImage(w, h, 5);
                sixth_bmp = LayerizeImage(w, h, 6);
                seventh_bmp = LayerizeImage(w, h, 7);
                eighth_bmp = LayerizeImage(w, h, 8);

                pbLayer1.Image = first_bmp;
                pbLayer2.Image = second_bmp;
                pbLayer3.Image = third_bmp;
                pbLayer4.Image = fourth_bmp;
                pbLayer5.Image = fifth_bmp;
                pbLayer6.Image = sixth_bmp;
                pbLayer7.Image = seventh_bmp;
                pbLayer8.Image = eighth_bmp;

                pboxPreview.Image = original_bmp;
                pboxStatic.Image = original_bmp;

                txtMessage.Text = BinaryToString(message, w, h);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

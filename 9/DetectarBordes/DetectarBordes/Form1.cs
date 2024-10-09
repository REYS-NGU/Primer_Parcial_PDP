using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectarBordes
{
    public partial class AppDetecBord : Form
    {
        public AppDetecBord()
        {
            InitializeComponent();
        }

        // Función personalizada para reemplazar Math.Clamp
        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private void CarIma_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos png|*.png|Archivos jpg|*.jpg";
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            ImagOrig.Image = bmp;
        }

        private void DecBor_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(ImagOrig.Image);
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);

            int[,] sX = new int[,]
    {
        { -1, 0, 1 },
        { -2, 0, 2 },
        { -1, 0, 1 }
    };

            int[,] sY = new int[,]
    {
        { 1, 2, 1 },
        { 0, 0, 0 },
        { -1, -2, -1 }
    };

            int umbral = 180; // Este valor puede ser ajustado para controlar la sensibilidad del borde

            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    int pixelX = 0;
                    int pixelY = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            Color pixelColor = bmp.GetPixel(i + k, j + l);
                            int gris = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                            pixelX += gris * sX[k + 1, l + 1];
                            pixelY += gris * sY[k + 1, l + 1];
                        }
                    }

                    int magnitud = (int)Math.Sqrt(pixelX * pixelX + pixelY * pixelY);

                    // Solo mostramos los bordes que superen un cierto umbral
                    if (magnitud > umbral)
                    {
                        magnitud = Clamp(magnitud, 0, 255);
                        result.SetPixel(i, j, Color.FromArgb(magnitud, magnitud, magnitud));
                    }
                    else
                    {
                        // Si la magnitud es menor que el umbral, el píxel se pone a negro (no borde)
                        result.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            ImagWithoutBord.Image = result;
        }
    }
}

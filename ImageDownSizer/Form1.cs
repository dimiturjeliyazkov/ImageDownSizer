using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageDownSizer
{
    public partial class Form1 : Form
    {
        private Image selectedImage;

        public Form1()
        {
            InitializeComponent();
        }

        public static Bitmap DownscaleImage(Image originalImage, double scaleFactor)
        {
            int newWidth = (int)(originalImage.Width * scaleFactor / 100.0);
            int newHeight = (int)(originalImage.Height * scaleFactor / 100.0);
            return DownscaleImage(originalImage, newWidth, newHeight);
        }

        public static Bitmap DownscaleImage(Image originalImage, int newWidth, int newHeight)
        {
            double widthScaleFactor = (double)newWidth / originalImage.Width;
            double heightScaleFactor = (double)newHeight / originalImage.Height;

            
            Bitmap newImage = new Bitmap(newWidth, newHeight);

            BitmapData originalData = ((Bitmap)originalImage).LockBits(new Rectangle(0, 0, originalImage.Width, originalImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData newData = newImage.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* originalPtr = (byte*)originalData.Scan0;
                byte* newPtr = (byte*)newData.Scan0;

                int originalStride = originalData.Stride;
                int newStride = newData.Stride;

                
                int numThreads = Environment.ProcessorCount;
                Thread[] threads = new Thread[numThreads];

                int rowsPerThread = newHeight / numThreads;

                for (int i = 0; i < numThreads; i++)
                {
                    int startY = i * rowsPerThread;
                    int endY = (i == numThreads - 1) ? newHeight : startY + rowsPerThread;

                    threads[i] = new Thread(() =>
                    {
                        for (int y = startY; y < endY; y++)
                        {
                            for (int x = 0; x < newWidth; x++)
                            {
                                int originalX = (int)(x / widthScaleFactor);
                                int originalY = (int)(y / heightScaleFactor);

                                byte* originalPixel = originalPtr + originalY * originalStride + originalX * 3;
                                byte* newPixel = newPtr + y * newStride + x * 3;

                                
                                newPixel[2] = originalPixel[2]; 
                                newPixel[1] = originalPixel[1]; 
                                newPixel[0] = originalPixel[0]; 
                            }
                        }
                    });
                }

                foreach (var thread in threads)
                {
                    thread.Start();
                }

                
                foreach (var thread in threads)
                {
                    thread.Join();
                }
            }

            ((Bitmap)originalImage).UnlockBits(originalData);
            newImage.UnlockBits(newData);

            return newImage;
        }


        private void ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png;)|*.bmp;*.jpg;*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                selectedImage = Image.FromFile(selectedFile);
                pictureBox.ClientSize = new Size(selectedImage.Width, selectedImage.Height);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = selectedImage;
            }
        }

        private void DownsizeImage_Click(object sender, EventArgs e)
        {
            if (selectedImage == null)
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double scaleFactor;
            if (!double.TryParse(procenti.Text, out scaleFactor))
            {
                MessageBox.Show("Invalid percentage value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap downscaledImage = DownscaleImage(selectedImage, scaleFactor);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = downscaledImage;
            pictureBox.ClientSize = new Size(downscaledImage.Width, downscaledImage.Height); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            InvertButton.Visible = false;
            SaveButton.Visible = false;

            // Add white background and text to OriginalPictureBox
            OriginalPictureBox.BackColor = Color.White;
            OriginalPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            OriginalPictureBox.Image = DrawText("No Image. Press open file", OriginalPictureBox.Size);

            // Add white background and text to InvertedPictureBox
            InvertedPictureBox.BackColor = Color.White;
            InvertedPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            InvertedPictureBox.Image = DrawText("No Image. Press open file", InvertedPictureBox.Size);


        }

        private Image DrawText(string text, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(Point.Empty, size)); // Fill with white background
                    graphics.DrawString(text, Font, brush, PointF.Empty);
                }
            }
            return bitmap;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Bitmap originalImage = new Bitmap(filePath);

                    OriginalPictureBox.Image = originalImage;

                    InvertButton.Visible = true;
                    SaveButton.Visible = true;


                }
            }
        }


        private Bitmap InvertImage(Bitmap original)
        {
            Bitmap invertedImage = new Bitmap(original.Width, original.Height);

            // Invert color components or full color based on selected mode
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    Color invertedColor;

                    // Check which inversion mode is selected
                    if (colorRadioButton.Checked)
                    {
                        // Invert color components (RGB)
                        invertedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    }
                    else if (fullColorRadioButton.Checked)
                    {
                        // Full color inversion
                        invertedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                        invertedColor = Color.FromArgb(255 - invertedColor.R, 255 - invertedColor.G, 255 - invertedColor.B);
                    }
                    else
                    {
                        // No inversion mode selected
                        MessageBox.Show("Please select an inversion style.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    invertedImage.SetPixel(x, y, invertedColor);
                }
            }

            return invertedImage;
        }

        private void InvertButton_Click(object sender, EventArgs e)
        {
            // Check if any radio button is selected
            if (!colorRadioButton.Checked && !fullColorRadioButton.Checked)
            {
                MessageBox.Show("Please select an inversion style.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected image
            Bitmap selectedImage = (Bitmap)OriginalPictureBox.Image;

            // Invert selected image based on the selected mode
            Bitmap invertedImage = InvertImage(selectedImage);

            //clear invertedpicturebox
            InvertedPictureBox.Image = null;

            // Display the inverted image
            InvertedPictureBox.Image = invertedImage;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Check if any radio button is selected
            if (!colorRadioButton.Checked && !fullColorRadioButton.Checked)
            {
                MessageBox.Show("Please select an inversion style.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Get the selected image
                    Bitmap selectedImage = (Bitmap)OriginalPictureBox.Image;

                    // Invert selected image based on the selected mode
                    Bitmap invertedImage = InvertImage(selectedImage);

                    // Save the inverted image
                    invertedImage.Save(filePath, ImageFormat.Bmp);

                    // Display the inverted image
                    InvertedPictureBox.Image = invertedImage;
                }
            }
        }
    }
}

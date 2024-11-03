using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            // PictureBox oluşturma ve form üzerine ekleme
            PictureBox pictureBox1 = new PictureBox
            {
                Name = "pictureBox1",
                Size = new Size(200, 200),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.Fixed3D
            };
            this.Controls.Add(pictureBox1); // Form üzerine ekledik

            // Show Button (Resim gösterme)
            Button showButton = new Button
            {
                Name = "showButton",
                Text = "Show a picture",
                Location = new Point(20, 250)
            };
            showButton.Click += showButton_Click; // Olay işleyicisi ekleme
            this.Controls.Add(showButton);

            // Clear Button (Resmi temizleme)
            Button clearButton = new Button
            {
                Name = "clearButton",
                Text = "Clear the picture",
                Location = new Point(120, 250)
            };
            clearButton.Click += clearButton_Click;
            this.Controls.Add(clearButton);

            // Background Color Button (Arka plan rengi değiştirme)
            Button backgroundButton = new Button
            {
                Name = "backgroundButton",
                Text = "Set background color",
                Location = new Point(220, 250)
            };
            backgroundButton.Click += backgroundButton_Click;
            this.Controls.Add(backgroundButton);

            // Close Button (Formu kapatma)
            Button closeButton = new Button
            {
                Name = "closeButton",
                Text = "Close",
                Location = new Point(350, 250)
            };
            closeButton.Click += closeButton_Click;
            this.Controls.Add(closeButton);

            // CheckBox (Resim modunu değiştirme - Stretch)
            CheckBox checkBox1 = new CheckBox
            {
                Name = "checkBox1",
                Text = "Stretch",
                Location = new Point(20, 280)
            };
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            this.Controls.Add(checkBox1);

            // OpenFileDialog bileşeni
            openFileDialog1 = new OpenFileDialog
            {
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*",
                Title = "Select a picture file"
            };

            // ColorDialog bileşeni
            colorDialog1 = new ColorDialog();
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void showButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the picture the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, change the PictureBox's SizeMode property to "Stretch". If the user clears the check box, change it to "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }


    }
}

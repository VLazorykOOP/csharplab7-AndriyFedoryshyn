using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task1 : Form
    {
        private Timer timer;
        private string[] imageFiles;
        private int currentIndex;
        public Task1()
        {
            InitializeComponent();
            InitializeTimer();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; // інтервал у мілісекундах
            timer.Tick += Timer_Tick;
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            // Збільшення індексу або перехід на початок, якщо потрібно
            currentIndex = (currentIndex + 1) % imageFiles.Length;

            // Відображення наступного зображення
            pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]);
        }





        private void Form1_Load_1(object sender, EventArgs e)
        {

            // Приклад шляху до теки з файлами
            string directoryPath = @"C:/Users/Андрій/Desktop/c#/Lab7CSharp/Images";

            // Отримання всіх файлів у заданій текі
            imageFiles = Directory.GetFiles(directoryPath, "*.jpg");

            // Перевірка, чи є файли у текі
            if (imageFiles.Length == 0)
            {
                MessageBox.Show("Немає зображень у заданій текі.");
                return;
            }

            // Початкове відображення першого зображення
            pictureBox1.Image = Image.FromFile(imageFiles[0]);
            currentIndex = 0;

            // Запуск таймера
            timer.Start();
        }
    

       

    }
}


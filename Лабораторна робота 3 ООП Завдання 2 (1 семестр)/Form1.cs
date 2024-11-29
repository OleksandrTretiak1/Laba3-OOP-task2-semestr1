using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;

namespace Laba_3_Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.BlueViolet;

            // Налаштування кольорів для елементів форми
            Color buttonBackground = Color.MediumSlateBlue;
            Color buttonTextColor = Color.White;

            Color listBoxBackground = Color.SlateBlue;
            Color listBoxTextColor = Color.White;

            Color pictureBoxBorder = Color.DarkSlateBlue;

            // Задаємо кольори для кнопок
            button1.BackColor = buttonBackground;
            button1.ForeColor = buttonTextColor;

            // Задаємо кольори та стиль для списків
            listBox1.BackColor = listBoxBackground;
            listBox1.ForeColor = listBoxTextColor;
            listBox1.BorderStyle = BorderStyle.FixedSingle;

            listBox2.BackColor = listBoxBackground;
            listBox2.ForeColor = listBoxTextColor;
            listBox2.BorderStyle = BorderStyle.FixedSingle;

            // Налаштовуємо рамки для PictureBox
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;

            // Налаштування кольору для другої кнопки
            button2.BackColor = buttonBackground;
            button2.ForeColor = buttonTextColor;
        }

        private List<string> filePaths = new List<string>();

        // Обробник кнопки "Завантажити зображення"
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Text = "Images"; // Текст для відображення у списку
            listBox1.Visible = true;
            this.Controls.Add(listBox1);
            listBox1.Items.Clear(); // Очищаємо список
            listBox1.BeginUpdate(); // Початок оновлення елементів списку
            string[] files = Directory.GetFiles("D:\\VisualStudio\\Лабораторна робота 3 ООП Завдання 2 (1 семестр)\\Images");

            // Регулярний вираз для перевірки розширень зображень
            Regex regexExtForImage = new Regex("^.((bmp)|(gif)|(tiff?)|(jpe?g)|(png))$", RegexOptions.IgnoreCase);

            foreach (var image in files)
            {
                // Додаємо тільки ті файли, що мають потрібні розширення
                if (regexExtForImage.IsMatch(Path.GetExtension(image)))
                {
                    listBox1.Items.Add(Path.GetFileName(image)); // Додаємо ім'я файлу до списку
                    filePaths.Add(image); // Зберігаємо повний шлях до файлу
                }
            }
            listBox1.EndUpdate(); // Завершуємо оновлення списку
        }

        // Обробник зміни розміру форми
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Центруємо кнопку на формі
            
            pictureBox1.Location = new Point(listBox1.Location.X, listBox1.Location.Y + listBox1.Height + 20); // Регулюємо розташування PictureBox
            pictureBox1.Size = new Size(listBox1.Width, listBox1.Height); // Задаємо розмір PictureBox
        }

        // Обробник вибору елемента у списку
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Visible = true; // Відображаємо PictureBox
                string selectedFilePath = filePaths[listBox1.SelectedIndex]; // Отримуємо шлях до вибраного файлу
                pictureBox1.Load(selectedFilePath); // Завантажуємо зображення у PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Встановлюємо режим розтягнення зображення
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Виводимо повідомлення про помилку
            }
        }

        // Обробник кнопки "Обернути зображення"
        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Text = "New images"; // Текст для відображення у списку
            listBox2.Visible = true;
            if (listBox1.SelectedItem == null)
            {
                // Якщо файл не вибрано
                MessageBox.Show("Будь ласка, оберіть файл зі списку.");
                return;
            }

            string selectedFilePath = filePaths[listBox1.SelectedIndex]; // Отримуємо шлях до вибраного файлу
            string targetDirectory = "D:\\VisualStudio\\Лабораторна робота 3 ООП Завдання 2 (1 семестр)\\New_images";

            try
            {
                // Завантажуємо вибране зображення
                Bitmap bitmap = new Bitmap(selectedFilePath);
                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX); // Обертаємо зображення горизонтально

                // Зберігаємо зображення у форматі GIF
                string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                string newFileName = fileName + ".gif";
                string filePathInDirectory = Path.Combine(targetDirectory, newFileName);
                bitmap.Save(filePathInDirectory, ImageFormat.Gif); // Зберігаємо зображення

                listBox2.Items.Add(newFileName); // Додаємо нове ім'я файлу до списку
                pictureBox2.Visible = true; // Відображаємо PictureBox для нового зображення
                pictureBox2.Load(filePathInDirectory); // Завантажуємо нове зображення
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; // Режим розтягнення зображення
                pictureBox2.Size = new System.Drawing.Size(225, 200);
    
                MessageBox.Show($"Файл успішно збережено як {newFileName}."); // Повідомлення про успішне збереження
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при обробці файлу: {ex.Message}"); // Повідомлення про помилку
            }
        }
    }
}

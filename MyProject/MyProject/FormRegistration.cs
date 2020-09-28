using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyProject
{
    public partial class FormRegistration : Form
    {
        Point lastPoint;
        static Random rnd = new Random();
        static int number = rnd.Next(99999);

        public FormRegistration()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        Point LastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

      

        private void labelClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FormRegistration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }



        private void labelStartMovie_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
             DialogResult DResult = MessageBox.Show("Вы готовы распечатать билет?", "Подтверждение",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);
            if (DResult == DialogResult.Yes)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".txt";
                saveFile.Filter = "text files|*.txt";
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                    {
                       
                        object Holl = DataBank.NameFilmIndex;
                        int Zal = Convert.ToInt32(Holl);
                        int result = Zal + 1;
                        DataBank.ResultNumber = result;
                        sw.WriteLine("Фильм: " + DataBank.NameFilm);
                        sw.WriteLine(labelPlace.Text);
                        sw.WriteLine(labelRow.Text);
                        sw.WriteLine("" + labelStartMovie.Text);
                        sw.WriteLine(labelDate.Text);
                        sw.WriteLine(labelBuy.Text);
                        sw.WriteLine(labelHoll.Text = "Зал: " + result);
                        sw.WriteLine(labelNumberTicket.Text = "№ билета " + number);
                        FormData FD = new FormData();
                        FD.Show();
                        this.Hide();

                    }
                }
            }
            else 
            {           
            }
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
           
                object Holl = DataBank.NameFilmIndex;
            int Zal = Convert.ToInt32(Holl);
            int result = Zal + 1;
            DataBank.ResultNumber = result;
            labelFilm.Text = "Фильм: " + DataBank.NameFilm;
            labelPlace.Text = "Место: " + DataBank.Place;
            labelRow.Text = "Ряд: " + DataBank.Row;
            labelStartMovie.Text = "Начало сеанса:" + DataBank.Time;
            labelDate.Text = "Дата: " + DataBank.Data;
            labelBuy.Text = DataBank.Price;
            labelHoll.Text = "Зал: " + result;    
            labelNumberTicket.Text = "№ билета: " + number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormData FD = new FormData();
            Hide();
            FD.ShowDialog();         
        }
    }
}

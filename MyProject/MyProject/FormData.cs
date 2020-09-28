using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class FormData : Form
    {
        

        public FormData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave_1(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelInputData_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelInputData_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void comboBoxFilms_MouseEnter(object sender, EventArgs e)
        {
            comboBoxFilms.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxHoll_MouseEnter(object sender, EventArgs e)
        {

        }
        private void comboBoxRow_MouseEnter(object sender, EventArgs e)
        {
            comboBoxRow.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void comboBoxPlace_MouseEnter(object sender, EventArgs e)
        {
            comboBoxPlace.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void comboBoxTime_MouseEnter(object sender, EventArgs e)
        {
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void comboBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;
            switch (comboBoxFilms.SelectedIndex)
            {
                case 0: price = 150; break;
                case 1: price = 200; break;
                case 2: price = 220; break;
                case 3: price = 250; break;
                case 4: price = 270; break;
            }
            string pricee = Convert.ToString(price);
            labelPrice.Text = "Цена билета: " + pricee + "";
        }
        private void comboBoxFilms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxFilms.SelectedIndex == 0)
            {
                comboBoxRow.Enabled = true;
                comboBoxPlace.Enabled = true;
                comboBoxTime.Enabled = true;
            }
            if (comboBoxFilms.SelectedIndex == 1)
            {
                comboBoxRow.Enabled = true;
                comboBoxPlace.Enabled = true;
                comboBoxTime.Enabled = true;
            }
            if (comboBoxFilms.SelectedIndex == 2)
            {
                comboBoxRow.Enabled = true;
                comboBoxPlace.Enabled = true;
                comboBoxTime.Enabled = true;
            }
            if (comboBoxFilms.SelectedIndex == 3)
            {
                comboBoxRow.Enabled = true;
                comboBoxPlace.Enabled = true;
                comboBoxTime.Enabled = true;
            }
        }
        private void comboBoxPlace_MouseUp(object sender, MouseEventArgs e)
        {
            labelHelp.Text = "Выберите время сеанса";
        }

        private void comboBoxTime_MouseUp(object sender, MouseEventArgs e)
        {
            labelHelp.Text = "Выберите дату";
        }

        private void comboBoxRow_MouseUp(object sender, MouseEventArgs e)
        {
            labelHelp.Text = "Выберите место";
        }

        private void comboBoxFilms_MouseDown(object sender, MouseEventArgs e)
        {
            labelHelp.Text = "Выберите ряд";
        }
       
        private void buttonTakeTicket_MouseLeave(object sender, EventArgs e)
        {
            buttonTakeTicket.BackColor = Color.White;
        }

        private void buttonTakeTicket_MouseEnter(object sender, EventArgs e)
        {
            buttonTakeTicket.BackColor = Color.GreenYellow;
        }

        private void dateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            labelHelp.Text="Получите билет";
        }
    }
}



using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.PasswordtextBox.AutoSize = false;
            this.PasswordtextBox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.LogintextBox.Text = "Введите логин";
            this.LogintextBox.ForeColor = Color.Gray;
            this.PasswordtextBox.Text = "Введите пароль";
            this.PasswordtextBox.ForeColor = Color.Gray;
            this.PasswordtextBox.UseSystemPasswordChar = false;
            this.label1.Select();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;

        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }


        private void LogintextBox_Enter(object sender, EventArgs e)
        {
            if (this.LogintextBox.Text == "Введите логин")
            {
                this.LogintextBox.Text = "";
                this.LogintextBox.ForeColor = Color.Black;
            }
        }
        private void LogintextBox_Leave(object sender, EventArgs e)
        {
            if (this.LogintextBox.Text == "")
            {
                this.LogintextBox.Text = "Введите логин";
                this.LogintextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordtextBox_Enter(object sender, EventArgs e)
        {
            if (this.PasswordtextBox.Text == "Введите пароль")
            {
                this.PasswordtextBox.UseSystemPasswordChar = true;
                this.PasswordtextBox.Text = "";
                this.PasswordtextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (this.PasswordtextBox.Text == "")
            {
                this.PasswordtextBox.Text = "Введите пароль";
                this.PasswordtextBox.ForeColor = Color.Gray;
                this.PasswordtextBox.UseSystemPasswordChar = false;
            }
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            if((this.LogintextBox.Text== "Введите логин" || this.LogintextBox.ForeColor==Color.Gray)|| (this.PasswordtextBox.Text == "Введите пароль" || this.PasswordtextBox.ForeColor == Color.Gray))
            {
                MessageBox.Show("Введите данные полностью!");
                return;
            }
            DataBase DB = new DataBase();
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `Login` = @login AND `Password` = @password",DB.GetConnection());
            Command.Parameters.Add("@login", MySqlDbType.VarChar).Value = this.LogintextBox.Text;
            Command.Parameters.Add("@password", MySqlDbType.VarChar).Value = this.PasswordtextBox.Text;
            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);
            if(Table.Rows.Count > 0) 
            {
                MessageBox.Show("Авторизация пройдена успешно!");
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                this.Hide();
                FunctionalScreen MainWindow = new FunctionalScreen(Table);
                MainWindow.Show();
            }
            else 
            {
                MessageBox.Show("Авторизация не пройдена!\nНеправильный логин или пароль");
                return;
            }
        }

        private void GoToRegistrationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.Show();
        }
    }
}

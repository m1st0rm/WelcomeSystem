using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.PasswordtextBox.AutoSize = false;
            this.PasswordtextBox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.TelephoneNumberTextBox.AutoSize = false;
            this.TelephoneNumberTextBox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.BirthdayDateTextBox.AutoSize = false;
            this.BirthdayDateTextBox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.CardNumberTextBox.AutoSize = false;
            this.CardNumberTextBox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.CVCCVVTextBox.AutoSize = false;
            this.CVCCVVTextBox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.CardDateTextbox.AutoSize = false;
            this.CardDateTextbox.Size = new Size(this.LogintextBox.Size.Width, this.LogintextBox.Size.Height);
            this.NametextBox.Text = "Введите имя";
            this.NametextBox.ForeColor = Color.Gray;
            this.SurnametextBox.Text = "Введите фамилию";
            this.SurnametextBox.ForeColor = Color.Gray;
            this.LogintextBox.Text = "Введите логин";
            this.LogintextBox.ForeColor = Color.Gray;
            this.PasswordtextBox.Text = "Введите пароль";
            this.PasswordtextBox.ForeColor = Color.Gray;
            this.PasswordtextBox.UseSystemPasswordChar = false;
            this.PatronymictextBox.Text = "Введите отчество";
            this.PatronymictextBox.ForeColor = Color.Gray;
            this.TelephoneNumberTextBox.Text = "Введите номер телефона";
            this.TelephoneNumberTextBox.ForeColor = Color.Gray;
            this.BirthdayDateTextBox.Text = "Введите дату рождения";
            this.BirthdayDateTextBox.ForeColor = Color.Gray;
            this.CardNumberTextBox.Text = "Введите номер банковской карты";
            this.CardNumberTextBox.ForeColor = Color.Gray;
            this.CVCCVVTextBox.Text = "Введите CVV/CVC карты";
            this.CVCCVVTextBox.ForeColor = Color.Gray;
            this.CardDateTextbox.Text = "Введите срок действия карты";
            this.CardDateTextbox.ForeColor = Color.Gray;
            this.label1.Select();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void NametextBox_Enter(object sender, EventArgs e)
        {
            if (this.NametextBox.Text == "Введите имя")
            {
                this.NametextBox.Text = "";
                this.NametextBox.ForeColor = Color.Black;
            }
        }

        private void NametextBox_Leave(object sender, EventArgs e)
        {
            if (this.NametextBox.Text == "")
            {
                this.NametextBox.Text = "Введите имя";
                this.NametextBox.ForeColor = Color.Gray;
            }
        }

        private void SurnametextBox_Enter(object sender, EventArgs e)
        {
            if (this.SurnametextBox.Text == "Введите фамилию")
            {
                this.SurnametextBox.Text = "";
                this.SurnametextBox.ForeColor = Color.Black;
            }
        }

        private void SurnametextBox_Leave(object sender, EventArgs e)
        {
            if (this.SurnametextBox.Text == "")
            {
                this.SurnametextBox.Text = "Введите фамилию";
                this.SurnametextBox.ForeColor = Color.Gray;
            }
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
                this.PasswordtextBox.UseSystemPasswordChar = false;
                this.PasswordtextBox.Text = "Введите пароль";
                this.PasswordtextBox.ForeColor = Color.Gray;
            }
        }
        private void GoToAuthbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm AuthForm = new AuthorizationForm();
            AuthForm.Show();
        }

        private void PatronymictextBox_Enter(object sender, EventArgs e)
        {
            if (this.PatronymictextBox.Text == "Введите отчество")
            {
                this.PatronymictextBox.Text = "";
                this.PatronymictextBox.ForeColor = Color.Black;
            }
        }

        private void PatronymictextBox_Leave(object sender, EventArgs e)
        {
            if (this.PatronymictextBox.Text == "")
            {
                this.PatronymictextBox.Text = "Введите отчество";
                this.PatronymictextBox.ForeColor = Color.Gray;
            }
        }

        private void TelephoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (this.TelephoneNumberTextBox.Text == "Введите номер телефона")
            {
                this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.TelephoneNumberTextBox.Mask = "+375(00)0000000";
                this.TelephoneNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void TelephoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (this.TelephoneNumberTextBox.Text.Length != 15)
            {
                MessageBox.Show("Введите номер телефона корректно!");
                this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                this.TelephoneNumberTextBox.Mask = default;
                this.TelephoneNumberTextBox.Text = "Введите номер телефона";
                this.TelephoneNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void BirthdayDateTextBox_Enter(object sender, EventArgs e)
        {
            if (this.BirthdayDateTextBox.Text == "Введите дату рождения")
            {
                this.BirthdayDateTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.BirthdayDateTextBox.Mask = "00/00/0000";
                this.BirthdayDateTextBox.ForeColor = Color.Black;
            }
        }

        private void BirthdayDateTextBox_Leave(object sender, EventArgs e)
        {
            DateTime ParseObject = new DateTime();
            if (!DateTime.TryParse(this.BirthdayDateTextBox.Text.ToString(), out ParseObject))
            {
                MessageBox.Show("Введите дату корректно!");
                this.BirthdayDateTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                this.BirthdayDateTextBox.Mask = default;
                this.BirthdayDateTextBox.Text = "Введите дату рождения";
                this.BirthdayDateTextBox.ForeColor = Color.Gray;
            }
        }

        private void CardNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (this.CardNumberTextBox.Text == "Введите номер банковской карты")
            {
                this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 22);
                this.CardNumberTextBox.Mask = "0000 0000 0000 0000";
                this.CardNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void CardNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (this.CardNumberTextBox.Text.Length != 19)
            {
                MessageBox.Show("Введите номер банковской карты корректно!");
                this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 14);
                this.CardNumberTextBox.Mask = default;
                this.CardNumberTextBox.Text = "Введите номер банковской карты";
                this.CardNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void CVCCVVTextBox_Enter(object sender, EventArgs e)
        {
            if (this.CVCCVVTextBox.Text == "Введите CVV/CVC карты")
            {
                this.CVCCVVTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.CVCCVVTextBox.Mask = "000";
                this.CVCCVVTextBox.ForeColor = Color.Black;
            }
        }

        private void CVCCVVTextBox_Leave(object sender, EventArgs e)
        {
            if (this.CVCCVVTextBox.Text.Length != 3)
            {
                MessageBox.Show("Введите CVV/CVC карты корректно!");
                this.CVCCVVTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                this.CVCCVVTextBox.Mask = default;
                this.CVCCVVTextBox.Text = "Введите CVV/CVC карты";
                this.CVCCVVTextBox.ForeColor = Color.Gray;
            }
        }

        private void CardDateTextbox_Enter(object sender, EventArgs e)
        {
            if (this.CardDateTextbox.Text == "Введите срок действия карты")
            {
                this.CardDateTextbox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.CardDateTextbox.Mask = "00/00";
                this.CardDateTextbox.ForeColor = Color.Black;
            }
        }

        private void CardDateTextbox_Leave(object sender, EventArgs e)
        {
            DateTime ParseObject = new DateTime();
            if (!DateTime.TryParse("01/" + this.CardDateTextbox.Text.ToString(), out ParseObject))
            {
                MessageBox.Show("Введите срок действия карты корректно!");
                this.CardDateTextbox.Font = new System.Drawing.Font("Times New Roman", 16);
                this.CardDateTextbox.Mask = default;
                this.CardDateTextbox.Text = "Введите срок действия карты";
                this.CardDateTextbox.ForeColor = Color.Gray;
            }
        }
        private Boolean LoginAvailabilityCheck()
        {
            DataBase DB = new DataBase();
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `Login` = @login", DB.GetConnection());
            Command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LogintextBox.Text;
            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private Boolean TelephoneNumberAvailabilityCheck() 
        {
            DataBase DB = new DataBase();
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `TelNumber` = @telnumber", DB.GetConnection());
            Command.Parameters.Add("@telnumber", MySqlDbType.VarChar).Value = TelephoneNumberTextBox.Text;
            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private Boolean CardNumberAvailabilityCheck() 
        {
            DataBase DB = new DataBase();
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `BankCardNumber` = @cardnumber", DB.GetConnection());
            Command.Parameters.Add("@cardnumber", MySqlDbType.VarChar).Value = CardNumberTextBox.Text;
            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);
            if (Table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void NametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Letter = e.KeyChar;
            if (!Char.IsLetter(Letter) && Letter != 8)
            {
                e.Handled = true;
            }
            if (Char.IsLetter(Letter) && NametextBox.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                return;
            }
        }

        private void SurnametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Letter = e.KeyChar;
            if (!Char.IsLetter(Letter) && Letter != 8)
            {
                e.Handled = true;
            }
            if (Char.IsLetter(Letter) && SurnametextBox.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                return;
            }
        }

        private void PatronymictextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Letter = e.KeyChar;
            if (!Char.IsLetter(Letter) && Letter != 8)
            {
                e.Handled = true;
            }
            if (Char.IsLetter(Letter) && PatronymictextBox.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                return;
            }
        }
        private void TelephoneNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "+375(  )")
            {
                ((MaskedTextBox)sender).SelectionStart = 5;
            }
        }

        private void BirthdayDateTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "  .  .")
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }

        private void CardNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "               ")
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }

        private void CVCCVVTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "")
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }

        private void CardDateTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "  .")
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }
        private void Registrationbutton_Click(object sender, EventArgs e)
        {
            if ((this.LogintextBox.Text == "Введите логин" || this.LogintextBox.ForeColor == Color.Gray) || (this.PasswordtextBox.Text == "Введите пароль" || this.PasswordtextBox.ForeColor == Color.Gray) || (this.NametextBox.Text == "Введите имя" || this.NametextBox.ForeColor == Color.Gray) || (this.SurnametextBox.Text == "Введите фамилию" || this.SurnametextBox.ForeColor == Color.Gray) || (this.PatronymictextBox.Text == "Введите отчество" || this.PatronymictextBox.ForeColor == Color.Gray) || (this.TelephoneNumberTextBox.Text == "Введите номер телефона" || this.TelephoneNumberTextBox.ForeColor == Color.Gray) || (this.BirthdayDateTextBox.Text == "Введите дату рождения" || this.BirthdayDateTextBox.ForeColor == Color.Gray) || (this.CardNumberTextBox.Text == "Введите номер банковской карты" || this.CardNumberTextBox.ForeColor == Color.Gray) || (this.CVCCVVTextBox.Text == "Введите CVV/CVC карты" || this.CVCCVVTextBox.ForeColor == Color.Gray) || (this.CardDateTextbox.Text == "Введите срок действия карты" || this.CardDateTextbox.ForeColor == Color.Gray))
            {
                MessageBox.Show("Введите данные полностью!");
                return;
            }
            if (!this.LoginAvailabilityCheck())
            {
                MessageBox.Show("Пользователь с таким логином уже существует!\nПопробуйте подобрать другой логин!");
                return;
            }
            if (!this.TelephoneNumberAvailabilityCheck())
            {
                MessageBox.Show("Пользователь с таким номером телефона уже существует!");
                return;
            }
            if (!this.CardNumberAvailabilityCheck())
            {
                MessageBox.Show("Пользователь с таким номером банковской карты уже существует!");
                return;
            }
            Random rand = new Random();
            DateTime Parseobject = new DateTime();
            DataBase DB = new DataBase();
            MySqlCommand Command = new MySqlCommand("INSERT INTO `clients` (`ID`, `Login`, `Password`, `Name`, `Surname`, `Patronymic`, `TelNumber`, `BirthdayDate`, `BankCardNumber`, `CVVCVC`, `CardDate`, `Money`) VALUES (@id, @login, @password, @name, @surname, @patronymic, @telnumber, @birthdaydate, @cardnumber, @cvvcvc, @carddate, @money)", DB.GetConnection());
            Command.Parameters.Add("@id", MySqlDbType.Int32).Value = rand.Next(0, 1000000000);
            Command.Parameters.Add("@login", MySqlDbType.VarChar).Value = this.LogintextBox.Text;
            Command.Parameters.Add("@password", MySqlDbType.VarChar).Value = this.PasswordtextBox.Text;
            Command.Parameters.Add("@name", MySqlDbType.VarChar).Value = this.NametextBox.Text;
            Command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = this.SurnametextBox.Text;
            Command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = this.PatronymictextBox.Text;
            Command.Parameters.Add("@telnumber", MySqlDbType.VarChar).Value = this.TelephoneNumberTextBox.Text;
            Parseobject = DateTime.Parse(this.BirthdayDateTextBox.Text.ToString());
            Command.Parameters.Add("@birthdaydate", MySqlDbType.VarChar).Value = Parseobject.ToString().Remove(10, 9);
            Command.Parameters.Add("@cardnumber", MySqlDbType.VarChar).Value = this.CardNumberTextBox.Text;
            Command.Parameters.Add("@cvvcvc", MySqlDbType.VarChar).Value = this.CVCCVVTextBox.Text;
            Parseobject = DateTime.Parse("01/" + this.CardDateTextbox.Text.ToString());
            Command.Parameters.Add("@carddate", MySqlDbType.VarChar).Value = Parseobject.ToString().Remove(0, 3).Remove(7, 9).Remove(3, 2);
            Command.Parameters.Add("@money", MySqlDbType.Int32).Value = rand.Next(100, 10000);
            DB.OpenConnection();
            if (Command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно!\nУчётная запись была создана!");
            }
            else
            {
                MessageBox.Show("Ошибка регистрации!\nУчётная запись не была создана!");
            }
            DB.CloseConnection();
        }

    }
}

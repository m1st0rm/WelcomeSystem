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
    public partial class FunctionalScreen : Form
    {
        DataTable UserInfo;
        public FunctionalScreen(DataTable UserInformation)
        {
            this.UserInfo = UserInformation;
            InitializeComponent();
            this.MeetingUser();
            this.CVCCVVTextBox.AutoSize = false;
            this.CVCCVVTextBox.Size = new Size(this.PasswordtextBox.Width, this.PasswordtextBox.Height);
            this.CardNumberTextBox.AutoSize = false;
            this.CardNumberTextBox.Size = new Size(this.PasswordtextBox.Width, this.PasswordtextBox.Height);
            this.TelephoneNumberTextBox.AutoSize = false;
            this.TelephoneNumberTextBox.Size = new Size(this.PasswordtextBox.Width, this.PasswordtextBox.Height);
            this.PasswordtextBox.Text = "Введите пароль";
            this.PasswordtextBox.ForeColor = Color.Gray;
            this.CVCCVVTextBox.Text = "Введите CVV/CVC вашей карты";
            this.CVCCVVTextBox.ForeColor = Color.Gray;
            this.CardNumberTextBox.Text = "Введите номер банковской карты получателя";
            this.CardNumberTextBox.ForeColor = Color.Gray;
            this.TelephoneNumberTextBox.Text = "Введите номер телефона получателя";
            this.TelephoneNumberTextBox.ForeColor = Color.Gray;
            this.SumTextBox.Text = "Сумма перевода";
            this.SumTextBox.ForeColor = Color.Gray;
            this.label1.Select();
        }
        private void UpdateUserInfo(DataBase DB)
        {
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `Login` = @login", DB.GetConnection());
            Command.Parameters.Add("@login", MySqlDbType.VarChar).Value = this.UserInfo.Rows[0]["Login"];
            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);
            this.UserInfo = Table;
        }
        private void MeetingUser()
        {
            string CardNumberWithHiddenElementsPart1 = this.UserInfo.Rows[0]["BankCardNumber"].ToString().Remove(4, 15);
            string CardNumberWithHiddenElementsPart2 = this.UserInfo.Rows[0]["BankCardNumber"].ToString().Remove(0, 14);
            this.MeetingLabel.Text = this.UserInfo.Rows[0]["Name"] + " " + this.UserInfo.Rows[0]["Patronymic"];
            this.CardNumberlabel.Text = CardNumberWithHiddenElementsPart1 + " **** ****" + CardNumberWithHiddenElementsPart2;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void CVCCVVTextBox_Enter(object sender, EventArgs e)
        {
            if (this.CVCCVVTextBox.Text == "Введите CVV/CVC вашей карты")
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
                this.CVCCVVTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.CVCCVVTextBox.Mask = default;
                this.CVCCVVTextBox.Text = "Введите CVV/CVC вашей карты";
                this.CVCCVVTextBox.ForeColor = Color.Gray;
            }
        }
        private void CardNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (this.CardNumberTextBox.Text == "Введите номер банковской карты получателя")
            {
                this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.CardNumberTextBox.Mask = "0000 0000 0000 0000";
                this.CardNumberTextBox.ForeColor = Color.Black;
            }
        }

        private void CardNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (this.CardNumberTextBox.Text.Length != 19)
            {
                MessageBox.Show("Введите номер банковской карты корректно!");
                this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                this.CardNumberTextBox.Mask = default;
                this.CardNumberTextBox.Text = "Введите номер банковской карты получателя";
                this.CardNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void TelephoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (this.TelephoneNumberTextBox.Text == "Введите номер телефона получателя")
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
                this.TelephoneNumberTextBox.Text = "Введите номер телефона получателя";
                this.TelephoneNumberTextBox.ForeColor = Color.Gray;
            }
        }
        private void SumTextBox_Enter(object sender, EventArgs e)
        {
            if (this.SumTextBox.Text == "Сумма перевода")
            {
                this.SumTextBox.MaxLength = 5;
                this.SumTextBox.Text = "";
                this.SumTextBox.ForeColor = Color.Black;
            }
        }

        private void SumTextBox_Leave(object sender, EventArgs e)
        {
            if (this.SumTextBox.Text == "")
            {
                this.SumTextBox.MaxLength = 14;
                this.SumTextBox.Text = "Сумма перевода";
                this.SumTextBox.ForeColor = Color.Gray;
            }
        }
        private void CVCCVVTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "")
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

        private void TelephoneNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text == "+375(  )")
            {
                ((MaskedTextBox)sender).SelectionStart = 5;
            }
        }
        private void SumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Letter = e.KeyChar;
            if (!Char.IsNumber(Letter) && Letter != 8)
            {
                e.Handled = true;
            }
        }

        private void GetInfromationButton_Click(object sender, EventArgs e)
        {
            if (this.PasswordtextBox.Text == "Введите пароль" || this.PasswordtextBox.ForeColor == Color.Gray)
            {
                MessageBox.Show("Введите пароль от вашей учётной записи!");
                return;
            }
            if (this.PasswordtextBox.Text != this.UserInfo.Rows[0]["Password"].ToString())
            {
                MessageBox.Show("Вы ввели неверный пароль!");
                this.PasswordtextBox.UseSystemPasswordChar = false;
                this.PasswordtextBox.Text = "Введите пароль";
                this.PasswordtextBox.ForeColor = Color.Gray;
                return;
            }
            else
            {
                this.Hide();
                InformationForm InfoWindow = new InformationForm(this, this.UserInfo);
                InfoWindow.Show();
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            HelloScreen NewHelloScreen = new HelloScreen();
            NewHelloScreen.Show();
            this.Close();
        }

        private void CardSumButton_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DataTable Table = new DataTable();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `BankCardNumber` = @cardnumber", DB.GetConnection());
            Command.Parameters.Add("@cardnumber", MySqlDbType.VarChar).Value = UserInfo.Rows[0]["BankCardNumber"];
            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);
            this.CardSumLabel.Text = Table.Rows[0]["Money"].ToString() + " BYN";
        }

        private void CardNumberTransferButton_Click(object sender, EventArgs e)
        {
            if ((SumTextBox.Text == "Сумма перевода" || this.SumTextBox.ForeColor == Color.Gray) || (this.CardNumberTextBox.Text == "Введите номер банковской карты получателя" || this.CardNumberTextBox.ForeColor == Color.Gray) || (this.PasswordtextBox.Text == "Введите пароль" || this.PasswordtextBox.ForeColor == Color.Gray) || (this.CVCCVVTextBox.Text == "Введите CVV/CVC вашей карты" || this.CVCCVVTextBox.ForeColor == Color.Gray))
            {
                MessageBox.Show("Введите данные полностью!");
                return;
            }
            if (this.PasswordtextBox.Text != this.UserInfo.Rows[0]["Password"].ToString())
            {
                MessageBox.Show("Вы ввели неверный пароль!");
                this.PasswordtextBox.UseSystemPasswordChar = false;
                this.PasswordtextBox.Text = "Введите пароль";
                this.PasswordtextBox.ForeColor = Color.Gray;
                return;
            }
            if (this.CVCCVVTextBox.Text != this.UserInfo.Rows[0]["CVVCVC"].ToString())
            {
                MessageBox.Show("Вы ввели неверный CVV/CVC код!");
                this.CVCCVVTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.CVCCVVTextBox.Mask = default;
                this.CVCCVVTextBox.Text = "Введите CVV/CVC вашей карты";
                this.CVCCVVTextBox.ForeColor = Color.Gray;
                return;
            }
            if (this.CardNumberTextBox.Text == this.UserInfo.Rows[0]["BankCardNumber"].ToString())
            {
                MessageBox.Show("Вы не можете осуществить перевод самому себе!");
                this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                this.CardNumberTextBox.Mask = default;
                this.CardNumberTextBox.Text = "Введите номер банковской карты получателя";
                this.CardNumberTextBox.ForeColor = Color.Gray;
                return;
            }
            if (Convert.ToInt32(this.SumTextBox.Text) > Convert.ToInt32(this.UserInfo.Rows[0]["Money"]))
            {
                MessageBox.Show("Недостаточно средств на банковской карте!");
                this.SumTextBox.MaxLength = 14;
                this.SumTextBox.Text = "Сумма перевода";
                this.SumTextBox.ForeColor = Color.Gray;
                return;
            }
            else
            {
                DataBase DB = new DataBase();
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `BankCardNumber` = @cardnumber", DB.GetConnection());
                Command.Parameters.Add("@cardnumber", MySqlDbType.VarChar).Value = this.CardNumberTextBox.Text;
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                if (Table.Rows.Count == 0)
                {
                    MessageBox.Show("Учётной записи с таким номером карты не существует!");
                    this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                    this.CardNumberTextBox.Mask = default;
                    this.CardNumberTextBox.Text = "Введите номер банковской карты получателя";
                    this.CardNumberTextBox.ForeColor = Color.Gray;
                    return;
                }
                else
                {
                    MySqlCommand CommandUpdate = new MySqlCommand("UPDATE `clients` SET `Money` = @newmoney WHERE `clients`.`BankCardNumber` = @cardnumber", DB.GetConnection());
                    CommandUpdate.Parameters.Add("@cardnumber", MySqlDbType.VarChar).Value = this.CardNumberTextBox.Text;
                    CommandUpdate.Parameters.Add("@newmoney", MySqlDbType.Int32).Value = Convert.ToInt32(Table.Rows[0]["Money"]) + Convert.ToInt32(this.SumTextBox.Text);
                    DB.OpenConnection();
                    int FirstOperation = CommandUpdate.ExecuteNonQuery();
                    DB.CloseConnection();
                    int Difference = Convert.ToInt32(this.UserInfo.Rows[0]["Money"]) - Convert.ToInt32(this.SumTextBox.Text);
                    MySqlCommand CommandUpdateAgain = new MySqlCommand("UPDATE `clients` SET `Money` = @newmoney WHERE `clients`.`Login` = @login", DB.GetConnection());
                    CommandUpdateAgain.Parameters.Add("@login", MySqlDbType.VarChar).Value = this.UserInfo.Rows[0]["Login"].ToString();
                    CommandUpdateAgain.Parameters.Add("@newmoney", MySqlDbType.Int32).Value = Difference;
                    DB.OpenConnection();
                    int SecondOperation = CommandUpdateAgain.ExecuteNonQuery();
                    DB.CloseConnection();
                    this.UpdateUserInfo(DB);
                    if (FirstOperation + SecondOperation == 2)
                    {
                        MessageBox.Show("Перевод прошёл успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка перевода!");
                    }
                }
            }
        }

        private void TelephoneNumberTransferButton_Click(object sender, EventArgs e)
        {
            if ((SumTextBox.Text == "Сумма перевода" || this.SumTextBox.ForeColor == Color.Gray) || (this.TelephoneNumberTextBox.Text == "Введите номер банковской карты получателя" || this.TelephoneNumberTextBox.ForeColor == Color.Gray) || (this.PasswordtextBox.Text == "Введите пароль" || this.PasswordtextBox.ForeColor == Color.Gray) || (this.CVCCVVTextBox.Text == "Введите CVV/CVC вашей карты" || this.CVCCVVTextBox.ForeColor == Color.Gray))
            {
                MessageBox.Show("Введите данные полностью!");
                return;
            }
            if (this.PasswordtextBox.Text != this.UserInfo.Rows[0]["Password"].ToString())
            {
                MessageBox.Show("Вы ввели неверный пароль!");
                this.PasswordtextBox.UseSystemPasswordChar = false;
                this.PasswordtextBox.Text = "Введите пароль";
                this.PasswordtextBox.ForeColor = Color.Gray;
                return;
            }
            if (this.CVCCVVTextBox.Text != this.UserInfo.Rows[0]["CVVCVC"].ToString())
            {
                MessageBox.Show("Вы ввели неверный CVV/CVC код!");
                this.CVCCVVTextBox.Font = new System.Drawing.Font("Times New Roman", 24);
                this.CVCCVVTextBox.Mask = default;
                this.CVCCVVTextBox.Text = "Введите CVV/CVC вашей карты";
                this.CVCCVVTextBox.ForeColor = Color.Gray;
                return;
            }
            if (this.TelephoneNumberTextBox.Text == this.UserInfo.Rows[0]["TelNumber"].ToString())
            {
                MessageBox.Show("Вы не можете осуществить перевод самому себе!");
                this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                this.TelephoneNumberTextBox.Mask = default;
                this.TelephoneNumberTextBox.Text = "Введите номер телефона получателя";
                this.TelephoneNumberTextBox.ForeColor = Color.Gray;
                return;
            }
            if (Convert.ToInt32(this.SumTextBox.Text) > Convert.ToInt32(this.UserInfo.Rows[0]["Money"]))
            {
                MessageBox.Show("Недостаточно средств на банковской карте!");
                this.SumTextBox.MaxLength = 14;
                this.SumTextBox.Text = "Сумма перевода";
                this.SumTextBox.ForeColor = Color.Gray;
                return;
            }
            else
            {
                DataBase DB = new DataBase();
                DataTable Table = new DataTable();
                MySqlDataAdapter Adapter = new MySqlDataAdapter();
                MySqlCommand Command = new MySqlCommand("SELECT * FROM `clients` WHERE `TelNumber` = @telnumber", DB.GetConnection());
                Command.Parameters.Add("@telnumber", MySqlDbType.VarChar).Value = this.TelephoneNumberTextBox.Text;
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                if (Table.Rows.Count == 0)
                {
                    MessageBox.Show("Учётной записи с таким номером телефона не существует!");
                    this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18);
                    this.TelephoneNumberTextBox.Mask = default;
                    this.TelephoneNumberTextBox.Text = "Введите номер телефона получателя";
                    this.TelephoneNumberTextBox.ForeColor = Color.Gray;
                    return;
                }
                else
                {
                    MySqlCommand CommandUpdate = new MySqlCommand("UPDATE `clients` SET `Money` = @newmoney WHERE `clients`.`TelNumber` = @telnumber", DB.GetConnection());
                    CommandUpdate.Parameters.Add("@telnumber", MySqlDbType.VarChar).Value = this.TelephoneNumberTextBox.Text;
                    CommandUpdate.Parameters.Add("@newmoney", MySqlDbType.Int32).Value = Convert.ToInt32(Table.Rows[0]["Money"]) + Convert.ToInt32(this.SumTextBox.Text);
                    DB.OpenConnection();
                    int FirstOperation = CommandUpdate.ExecuteNonQuery();
                    DB.CloseConnection();
                    int Difference = Convert.ToInt32(this.UserInfo.Rows[0]["Money"]) - Convert.ToInt32(this.SumTextBox.Text);
                    MySqlCommand CommandUpdateAgain = new MySqlCommand("UPDATE `clients` SET `Money` = @newmoney WHERE `clients`.`Login` = @login", DB.GetConnection());
                    CommandUpdateAgain.Parameters.Add("@login", MySqlDbType.VarChar).Value = this.UserInfo.Rows[0]["Login"].ToString();
                    CommandUpdateAgain.Parameters.Add("@newmoney", MySqlDbType.Int32).Value = Difference;
                    DB.OpenConnection();
                    int SecondOperation = CommandUpdateAgain.ExecuteNonQuery();
                    DB.CloseConnection();
                    this.UpdateUserInfo(DB);
                    if (FirstOperation + SecondOperation == 2)
                    {
                        MessageBox.Show("Перевод прошёл успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка перевода!");
                    }
                }
            }
        }
    }
}


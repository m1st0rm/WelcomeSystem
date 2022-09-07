
namespace ExampleSQLApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.Registrationbutton = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.GoToAuthbutton = new System.Windows.Forms.Button();
            this.PatronymictextBox = new System.Windows.Forms.TextBox();
            this.TelephoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BirthdayDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CardNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CVCCVVTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CardDateTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(765, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(44, 43);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Registrationbutton
            // 
            this.Registrationbutton.AutoSize = true;
            this.Registrationbutton.BackColor = System.Drawing.Color.Transparent;
            this.Registrationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrationbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Registrationbutton.FlatAppearance.BorderSize = 2;
            this.Registrationbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Registrationbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Registrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrationbutton.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Bold);
            this.Registrationbutton.Location = new System.Drawing.Point(470, 720);
            this.Registrationbutton.Name = "Registrationbutton";
            this.Registrationbutton.Size = new System.Drawing.Size(304, 44);
            this.Registrationbutton.TabIndex = 13;
            this.Registrationbutton.Text = "Зарегистрироваться";
            this.Registrationbutton.UseVisualStyleBackColor = false;
            this.Registrationbutton.Click += new System.EventHandler(this.Registrationbutton_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordtextBox.Location = new System.Drawing.Point(115, 634);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(283, 44);
            this.PasswordtextBox.TabIndex = 12;
            this.PasswordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            this.PasswordtextBox.Enter += new System.EventHandler(this.PasswordtextBox_Enter);
            this.PasswordtextBox.Leave += new System.EventHandler(this.PasswordtextBox_Leave);
            // 
            // LogintextBox
            // 
            this.LogintextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogintextBox.Location = new System.Drawing.Point(115, 494);
            this.LogintextBox.Multiline = true;
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(283, 63);
            this.LogintextBox.TabIndex = 11;
            this.LogintextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogintextBox.Enter += new System.EventHandler(this.LogintextBox_Enter);
            this.LogintextBox.Leave += new System.EventHandler(this.LogintextBox_Leave);
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NametextBox.Location = new System.Drawing.Point(481, 139);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(283, 63);
            this.NametextBox.TabIndex = 15;
            this.NametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NametextBox.Enter += new System.EventHandler(this.NametextBox_Enter);
            this.NametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NametextBox_KeyPress);
            this.NametextBox.Leave += new System.EventHandler(this.NametextBox_Leave);
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnametextBox.Location = new System.Drawing.Point(481, 208);
            this.SurnametextBox.Multiline = true;
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(283, 63);
            this.SurnametextBox.TabIndex = 16;
            this.SurnametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SurnametextBox.Enter += new System.EventHandler(this.SurnametextBox_Enter);
            this.SurnametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnametextBox_KeyPress);
            this.SurnametextBox.Leave += new System.EventHandler(this.SurnametextBox_Leave);
            // 
            // GoToAuthbutton
            // 
            this.GoToAuthbutton.AutoSize = true;
            this.GoToAuthbutton.BackColor = System.Drawing.Color.Transparent;
            this.GoToAuthbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToAuthbutton.FlatAppearance.BorderSize = 2;
            this.GoToAuthbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GoToAuthbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GoToAuthbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToAuthbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToAuthbutton.Location = new System.Drawing.Point(103, 720);
            this.GoToAuthbutton.Name = "GoToAuthbutton";
            this.GoToAuthbutton.Size = new System.Drawing.Size(295, 44);
            this.GoToAuthbutton.TabIndex = 17;
            this.GoToAuthbutton.Text = "Уже есть учётная запись?";
            this.GoToAuthbutton.UseVisualStyleBackColor = false;
            this.GoToAuthbutton.Click += new System.EventHandler(this.GoToAuthbutton_Click);
            // 
            // PatronymictextBox
            // 
            this.PatronymictextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymictextBox.Location = new System.Drawing.Point(481, 283);
            this.PatronymictextBox.Multiline = true;
            this.PatronymictextBox.Name = "PatronymictextBox";
            this.PatronymictextBox.Size = new System.Drawing.Size(283, 63);
            this.PatronymictextBox.TabIndex = 19;
            this.PatronymictextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatronymictextBox.Enter += new System.EventHandler(this.PatronymictextBox_Enter);
            this.PatronymictextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymictextBox_KeyPress);
            this.PatronymictextBox.Leave += new System.EventHandler(this.PatronymictextBox_Leave);
            // 
            // TelephoneNumberTextBox
            // 
            this.TelephoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneNumberTextBox.Location = new System.Drawing.Point(481, 352);
            this.TelephoneNumberTextBox.Name = "TelephoneNumberTextBox";
            this.TelephoneNumberTextBox.Size = new System.Drawing.Size(283, 35);
            this.TelephoneNumberTextBox.TabIndex = 20;
            this.TelephoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TelephoneNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TelephoneNumberTextBox_MouseClick);
            this.TelephoneNumberTextBox.Enter += new System.EventHandler(this.TelephoneNumberTextBox_Enter);
            this.TelephoneNumberTextBox.Leave += new System.EventHandler(this.TelephoneNumberTextBox_Leave);
            // 
            // BirthdayDateTextBox
            // 
            this.BirthdayDateTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDateTextBox.Location = new System.Drawing.Point(481, 421);
            this.BirthdayDateTextBox.Name = "BirthdayDateTextBox";
            this.BirthdayDateTextBox.Size = new System.Drawing.Size(283, 35);
            this.BirthdayDateTextBox.TabIndex = 21;
            this.BirthdayDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BirthdayDateTextBox.ValidatingType = typeof(System.DateTime);
            this.BirthdayDateTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BirthdayDateTextBox_MouseClick);
            this.BirthdayDateTextBox.Enter += new System.EventHandler(this.BirthdayDateTextBox_Enter);
            this.BirthdayDateTextBox.Leave += new System.EventHandler(this.BirthdayDateTextBox_Leave);
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.CardNumberTextBox.Location = new System.Drawing.Point(481, 494);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(283, 29);
            this.CardNumberTextBox.TabIndex = 22;
            this.CardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CardNumberTextBox.ValidatingType = typeof(System.DateTime);
            this.CardNumberTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CardNumberTextBox_MouseClick);
            this.CardNumberTextBox.Enter += new System.EventHandler(this.CardNumberTextBox_Enter);
            this.CardNumberTextBox.Leave += new System.EventHandler(this.CardNumberTextBox_Leave);
            // 
            // CVCCVVTextBox
            // 
            this.CVCCVVTextBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.CVCCVVTextBox.Location = new System.Drawing.Point(481, 641);
            this.CVCCVVTextBox.Name = "CVCCVVTextBox";
            this.CVCCVVTextBox.Size = new System.Drawing.Size(283, 35);
            this.CVCCVVTextBox.TabIndex = 23;
            this.CVCCVVTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CVCCVVTextBox.ValidatingType = typeof(System.DateTime);
            this.CVCCVVTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CVCCVVTextBox_MouseClick);
            this.CVCCVVTextBox.Enter += new System.EventHandler(this.CVCCVVTextBox_Enter);
            this.CVCCVVTextBox.Leave += new System.EventHandler(this.CVCCVVTextBox_Leave);
            // 
            // CardDateTextbox
            // 
            this.CardDateTextbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.CardDateTextbox.Location = new System.Drawing.Point(481, 571);
            this.CardDateTextbox.Name = "CardDateTextbox";
            this.CardDateTextbox.Size = new System.Drawing.Size(283, 32);
            this.CardDateTextbox.TabIndex = 24;
            this.CardDateTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CardDateTextbox.ValidatingType = typeof(System.DateTime);
            this.CardDateTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CardDateTextbox_MouseClick);
            this.CardDateTextbox.Enter += new System.EventHandler(this.CardDateTextbox_Enter);
            this.CardDateTextbox.Leave += new System.EventHandler(this.CardDateTextbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(141, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 25;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::ExampleSQLApp.Properties.Resources.Frame_1;
            this.ClientSize = new System.Drawing.Size(800, 774);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardDateTextbox);
            this.Controls.Add(this.CVCCVVTextBox);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.BirthdayDateTextBox);
            this.Controls.Add(this.TelephoneNumberTextBox);
            this.Controls.Add(this.PatronymictextBox);
            this.Controls.Add(this.GoToAuthbutton);
            this.Controls.Add(this.SurnametextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Registrationbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.LogintextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Registrationbutton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox SurnametextBox;
        private System.Windows.Forms.Button GoToAuthbutton;
        private System.Windows.Forms.TextBox PatronymictextBox;
        private System.Windows.Forms.MaskedTextBox TelephoneNumberTextBox;
        private System.Windows.Forms.MaskedTextBox BirthdayDateTextBox;
        private System.Windows.Forms.MaskedTextBox CardNumberTextBox;
        private System.Windows.Forms.MaskedTextBox CVCCVVTextBox;
        private System.Windows.Forms.MaskedTextBox CardDateTextbox;
        private System.Windows.Forms.Label label1;
    }
}
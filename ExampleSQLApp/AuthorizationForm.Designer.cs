
namespace ExampleSQLApp
{
    partial class AuthorizationForm
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
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GoToRegistrationbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogintextBox
            // 
            this.LogintextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogintextBox.Location = new System.Drawing.Point(29, 172);
            this.LogintextBox.Multiline = true;
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(358, 63);
            this.LogintextBox.TabIndex = 3;
            this.LogintextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogintextBox.Enter += new System.EventHandler(this.LogintextBox_Enter);
            this.LogintextBox.Leave += new System.EventHandler(this.LogintextBox_Leave);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordtextBox.Location = new System.Drawing.Point(29, 279);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(358, 44);
            this.PasswordtextBox.TabIndex = 4;
            this.PasswordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            this.PasswordtextBox.Enter += new System.EventHandler(this.PasswordtextBox_Enter);
            this.PasswordtextBox.Leave += new System.EventHandler(this.PasswordtextBox_Leave);
            // 
            // LogInbutton
            // 
            this.LogInbutton.AutoSize = true;
            this.LogInbutton.BackColor = System.Drawing.Color.Transparent;
            this.LogInbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInbutton.FlatAppearance.BorderSize = 3;
            this.LogInbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogInbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbutton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInbutton.Location = new System.Drawing.Point(344, 357);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(130, 48);
            this.LogInbutton.TabIndex = 6;
            this.LogInbutton.Text = "Войти";
            this.LogInbutton.UseVisualStyleBackColor = false;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
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
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(768, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitButton.Size = new System.Drawing.Size(44, 43);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GoToRegistrationbutton
            // 
            this.GoToRegistrationbutton.AutoSize = true;
            this.GoToRegistrationbutton.BackColor = System.Drawing.Color.Transparent;
            this.GoToRegistrationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToRegistrationbutton.FlatAppearance.BorderSize = 3;
            this.GoToRegistrationbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GoToRegistrationbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GoToRegistrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToRegistrationbutton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToRegistrationbutton.Location = new System.Drawing.Point(267, 415);
            this.GoToRegistrationbutton.Name = "GoToRegistrationbutton";
            this.GoToRegistrationbutton.Size = new System.Drawing.Size(291, 41);
            this.GoToRegistrationbutton.TabIndex = 18;
            this.GoToRegistrationbutton.Text = "Ещё нет учётной записи?";
            this.GoToRegistrationbutton.UseVisualStyleBackColor = false;
            this.GoToRegistrationbutton.Click += new System.EventHandler(this.GoToRegistrationbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(527, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ExampleSQLApp.Properties.Resources.Frame_4;
            this.ClientSize = new System.Drawing.Size(804, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoToRegistrationbutton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.LogintextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button GoToRegistrationbutton;
        private System.Windows.Forms.Label label1;
    }
}
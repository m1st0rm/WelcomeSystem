
namespace ExampleSQLApp
{
    partial class HelloScreen
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
            this.AuthButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
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
            this.ExitButton.Location = new System.Drawing.Point(736, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(44, 43);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AuthButton
            // 
            this.AuthButton.AutoSize = true;
            this.AuthButton.BackColor = System.Drawing.Color.Transparent;
            this.AuthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthButton.FlatAppearance.BorderSize = 3;
            this.AuthButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AuthButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AuthButton.Location = new System.Drawing.Point(273, 163);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(218, 75);
            this.AuthButton.TabIndex = 13;
            this.AuthButton.Text = "Авторизация";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.AutoSize = true;
            this.RegistrationButton.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.FlatAppearance.BorderSize = 3;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegistrationButton.Location = new System.Drawing.Point(273, 262);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(218, 78);
            this.RegistrationButton.TabIndex = 15;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(573, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // HelloScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExampleSQLApp.Properties.Resources.Frame_3;
            this.ClientSize = new System.Drawing.Size(771, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AuthButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelloScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloScreen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelloScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelloScreen_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label label1;
    }
}
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
    public partial class HelloScreen : Form
    {
        public HelloScreen()
        {
            InitializeComponent();
            this.label1.Select();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;

        private void HelloScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void HelloScreen_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm AuthForm = new AuthorizationForm();
            AuthForm.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.Show();
        }
    }
}

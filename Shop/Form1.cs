using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2SignIn secondForm = new Form2SignIn();
            secondForm.ShowDialog();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeCSharpWinForms
{
    public partial class AppMainWindow : Form
    {
        public AppMainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is a just test program!");
        }

        private void btnSubmitClick(object sender, EventArgs e)
        {
            if (textBoxName.Text != null)
            {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Hello World /n" +
                    "Hallo" + textBoxName.Text;
            } else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Please enter your name?";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainManagement trainManagement = new TrainManagement();
            trainManagement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberManagement memberManagement = new MemberManagement();
            memberManagement.Show();
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();

        }
    }
}

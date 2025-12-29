using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        private void btnSubmitMessage_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you sure you want to submit this student? ", "Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Question ,MessageBoxDefaultButton.Button1) == DialogResult.OK )
            {
                MessageBox.Show("User Pressed Ok");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel this student?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("User Pressed Ok");
            }
            Application.Exit();
        }
    }
}

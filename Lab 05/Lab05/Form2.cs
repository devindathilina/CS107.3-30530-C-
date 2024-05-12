using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form2 : Form
    {
        public string firstname { get; set; }

        public string lastname { get; set; }
        public string username { get; set; }

        public string email { get; set; }

        public Form2()

        {
            InitializeComponent();
        }

        
        private void btnsignup_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = $"{firstname} {lastname}";
            label2.Text = username;
            label3.Text = email;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoProject
{
    public partial class Form1 : Form
    {
        private Image imageFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            string text = tbData.Text.ToString();
            string key = tbKey.Text;

            tbResult.Text = RC4.Encrypt(text,key);

            //label1.Text=RC4.ImageToByteArray()

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            string text = tbData.Text.ToString();
            string key = tbKey.Text;

            tbResult.Text = RC4.Encrypt(text, key);
        }
    }
}

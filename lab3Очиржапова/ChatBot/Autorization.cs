using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class Autorization : Form
    {
        string s;
        public Autorization()
        {
            InitializeComponent();
        }

        private void Button_name_Click(object sender, EventArgs e)
        {
            ChatBot f = new ChatBot(this);
            f.Owner = this;
            f.ShowDialog();
            Hide();
        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

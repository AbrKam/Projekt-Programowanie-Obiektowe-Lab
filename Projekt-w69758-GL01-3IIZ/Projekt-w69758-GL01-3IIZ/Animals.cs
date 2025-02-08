using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_w69758_GL01_3IIZ
{
    public partial class Animals : UserControl
    {
        public Animals()
        {
            InitializeComponent();
        }

        // animal add button
        private void button1_Click(object sender, EventArgs e)
        {
            Form dataWindow = new EnterAnimalInfoPopUp();
            dataWindow.Show();
        }

        private void Animals_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

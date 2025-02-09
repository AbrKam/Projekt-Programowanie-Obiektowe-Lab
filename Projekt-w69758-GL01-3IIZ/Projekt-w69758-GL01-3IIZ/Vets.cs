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
    public partial class Vets : UserControl
    {
        public Vets()
        {
            InitializeComponent();
        }

        private void AddVetButton_Click(object sender, EventArgs e)
        {
            Form vetData = new EnterVetInfoPopUp();
            vetData.Show();
        }

        private void EditVetButton_Click(object sender, EventArgs e)
        {
            Form vetData = new EnterVetInfoPopUp();
            vetData.Show();
        }

        private void DeleteVetButton_Click(object sender, EventArgs e)
        {

        }
    }
}

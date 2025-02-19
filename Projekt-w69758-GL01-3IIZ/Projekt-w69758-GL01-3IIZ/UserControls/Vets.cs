using Microsoft.EntityFrameworkCore;
using Projekt_w69758_GL01_3IIZ.DbFunctionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_w69758_GL01_3IIZ
{
    public partial class Vets : UserControl
    {
        private DBManager _dbManager;
        public Vets()
        {
            InitializeComponent();
            _dbManager = new DBManager();
        }

        private void Vets_Load(object sender, EventArgs e)
        {
            LoadVetData(_dbManager);
        }

        private void AddVetButton_Click(object sender, EventArgs e)
        {
            Form vetData = new AddVetInfoPopUp();
            vetData.Show();
        }

        private void EditVetButton_Click(object sender, EventArgs e)
        {
            Form vetData = new AddVetInfoPopUp();
            vetData.Show();
        }

        private void DeleteVetButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadVetData(DBManager dbContext)
        {
            var vets = dbContext.Vets.ToList();

            if (vets.Any())
            {
                VetDataGrid.DataSource = vets;
            }
            else
            {
                MessageBox.Show("Brak danych w tabeli Weterynarze.");
            }
        }


    }
}

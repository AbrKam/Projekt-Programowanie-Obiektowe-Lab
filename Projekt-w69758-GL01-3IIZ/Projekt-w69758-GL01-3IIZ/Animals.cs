using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Projekt_w69758_GL01_3IIZ.Models;

namespace Projekt_w69758_GL01_3IIZ
{
    public partial class Animals : UserControl
    {
        private DBManager _dBManager;
        public Animals()
        {
            InitializeComponent();
            _dBManager = new DBManager();
        }

        private void Animals_Load(object sender, EventArgs e)
        {
            LoadAnimalData(_dBManager);
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            Form dataWindow = new EnterAnimalInfoPopUp();
            dataWindow.Show();
        }

        private void EditAnimalButton_Click(object sender, EventArgs e)
        {
            Form dataWindow = new EnterAnimalInfoPopUp();
            dataWindow.Show();
        }

        private void DeleteAnimalButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadAnimalData(DBManager dbContext)
        {
            var animals = dbContext.Animals.ToList();

            if (animals.Any())
            {
                AnimalDataGrid.DataSource = animals;
            }
            else
            {
                MessageBox.Show("Brak danych w zwierząt.");
            }
        }

    }
}

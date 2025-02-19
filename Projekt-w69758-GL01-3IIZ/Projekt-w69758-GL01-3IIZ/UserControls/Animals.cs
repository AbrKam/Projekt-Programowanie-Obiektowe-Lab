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
using Projekt_w69758_GL01_3IIZ.DbFunctionality;

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
            AddAnimalInfoPopUp dataWindow = new AddAnimalInfoPopUp();
            dataWindow.DataUpdated += () => RefreshDataGrid(_dBManager);
            dataWindow.ShowDialog();   
        }

        private void EditAnimalButton_Click(object sender, EventArgs e)
        {
            if (AnimalDataGrid.SelectedRows.Count > 0)
            {
                int selectedAnimalId = Convert.ToInt16(AnimalDataGrid.SelectedRows[0].Cells["Id"].Value);
                Animal? animalToEdit = _dBManager.Animals
                        .FirstOrDefault(o => o.Id == selectedAnimalId);

                Owner? ownerInfo = _dBManager.Owners.FirstOrDefault(o => o.Id == animalToEdit.Id);

                Form dataWindow = new AddAnimalInfoPopUp(animalToEdit, ownerInfo);
                dataWindow.Show();
            }
            else
            {
                MessageBox.Show("To edit you need to select full row.");
            }
        }

        private void DeleteAnimalButton_Click(object sender, EventArgs e)
        {
            //AnimalDataGrid.SelectedRows.
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
                MessageBox.Show("Brak danych zwierząt.");
            }
        }

        internal void RefreshDataGrid(DBManager dbContext)
        {
            AnimalDataGrid.DataSource = null;
            AnimalDataGrid.DataSource = dbContext.Animals.ToList();
        }
    }
}

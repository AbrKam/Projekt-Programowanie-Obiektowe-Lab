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
using Projekt_w69758_GL01_3IIZ.EditFunctionality;

namespace Projekt_w69758_GL01_3IIZ
{
    public partial class Animals : UserControl
    {
        public Animals()
        {
            InitializeComponent();
        }

        private void Animals_Load(object sender, EventArgs e)
        {
            using (DBManager dbContext = new DBManager()) 
            {
                LoadAnimalData(dbContext);
            }
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            using (DBManager dbContext = new DBManager()) 
            {
                AddAnimalInfoPopUp dataWindow = new AddAnimalInfoPopUp();
                dataWindow.DataUpdated += () => RefreshDataGrid(dbContext);
                dataWindow.ShowDialog();
            }
        }

        private void EditAnimalButton_Click(object sender, EventArgs e)
        {
            if (AnimalDataGrid.SelectedRows.Count > 0)
            {
                using (DBManager dbContext = new DBManager())
                {
                    int selectedAnimalId = Convert.ToInt16(AnimalDataGrid.SelectedRows[0].Cells["Id"].Value);
                    Animal? animalToEdit = dbContext.Animals
                            .FirstOrDefault(o => o.Id == selectedAnimalId);

                    Owner? ownerInfo = dbContext.Owners.FirstOrDefault(o => o.Id == animalToEdit.OwnerId);

                    EditAnimalInfoPopUp dataWindow = new EditAnimalInfoPopUp(animalToEdit, ownerInfo);
                    dataWindow.DataUpdated += () => RefreshDataGrid(dbContext);
                    dataWindow.ShowDialog();
                }
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

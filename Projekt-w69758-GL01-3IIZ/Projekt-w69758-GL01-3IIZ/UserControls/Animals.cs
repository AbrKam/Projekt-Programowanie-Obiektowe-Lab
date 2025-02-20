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
            int animalId = Convert.ToInt16(AnimalDataGrid.SelectedRows[0].Cells["Id"].Value);

            using (DBManager dbContext = new DBManager())
            {
                Animal? animalToDelete = dbContext.Animals.FirstOrDefault(o => o.Id == animalId);
                if (animalToDelete != null)
                {
                    dbContext.Animals.Remove(animalToDelete);
                    dbContext.SaveChanges();
                    RefreshDataGrid(dbContext);
                    MessageBox.Show("Animal deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Could not find animal to delete in the database.");
                }
            }
        }

        private void LoadAnimalData(DBManager dbContext)
        {
            //var animals = dbContext.Animals.ToList();

            var query = from a in dbContext.Animals
                        join o in dbContext.Owners
                        on a.Id equals o.Id
                        select new
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Breed = a.Breed,
                            Species = a.Species,
                            Age = a.Age,
                            Owner = o.FirstName + " " + o.LastName,
                            Email = o.Email,
                            TelNumber = o.TelephoneNumber
                        };
            var dataToDisplay = query.ToList();

            if (dataToDisplay.Any())
            {
                AnimalDataGrid.DataSource = dataToDisplay;
            }
            else
            {
                MessageBox.Show("Could not retrieve any animal data from the database.");
            }
        }

        internal void RefreshDataGrid(DBManager dbContext)
        {
            AnimalDataGrid.DataSource = null;
            //AnimalDataGrid.DataSource = dbContext.Animals.ToList();
            var query = from a in dbContext.Animals
                        join o in dbContext.Owners
                        on a.OwnerId equals o.Id
                        select new
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Breed = a.Breed,
                            Species = a.Species,
                            Age = a.Age,
                            Owner = o.FirstName + " " + o.LastName,
                            Email = o.Email,
                            TelNumber = o.TelephoneNumber
                        };

            var dataToDisplay = query.ToList();
            AnimalDataGrid.DataSource = dataToDisplay;
        }
    }
}

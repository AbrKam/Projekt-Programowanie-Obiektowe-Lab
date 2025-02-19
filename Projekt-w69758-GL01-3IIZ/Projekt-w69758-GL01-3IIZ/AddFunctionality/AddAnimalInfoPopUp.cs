using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Projekt_w69758_GL01_3IIZ.DbFunctionality;
using Projekt_w69758_GL01_3IIZ.Models;

namespace Projekt_w69758_GL01_3IIZ
{
    public partial class AddAnimalInfoPopUp : Form
    {
        private DBManager _dbContext;
        private Animal? _animal;
        private Owner? _owner;

        public event Action? DataUpdated;

        public AddAnimalInfoPopUp()
        {
            InitializeComponent();
            _dbContext = new DBManager();
        }

        public AddAnimalInfoPopUp(Animal animal, Owner owner)
        {
            InitializeComponent();
            _dbContext = new DBManager();
            _animal = animal;
            _owner = owner;
            LoadData();
        }

        private void EnterAnimalInfo_Click(object sender, EventArgs e)
        {
            try 
            {
                Owner? existingOwner = _dbContext.Owners
                        .FirstOrDefault(o => o.FirstName == OwnerFNameTextBox.Text 
                                            && o.LastName == OwnerLNameTextBox.Text
                                            && o.TelephoneNumber == OwnerTelNumber.Text);

                if (existingOwner != null)
                {

                    Animal animalToAdd = new Animal()
                    {
                        Name = AnimalNameTextBox.Text,
                        Breed = AnimalBreedTextBox.Text,
                        Species = AnimalSepciesTextBox.Text,
                        Age = Convert.ToInt16(AnimalAgeTextBox.Text),
                        OwnerId = existingOwner.Id
                    };

                    _dbContext.Add<Animal>(animalToAdd);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Animal info added successfully to the database.");
                    DataUpdated?.Invoke();
                    this.Close();
                }
                else
                {
                    Owner animalOwner = new Owner()
                    {
                        FirstName = OwnerFNameTextBox.Text,
                        LastName = OwnerLNameTextBox.Text,
                        TelephoneNumber = OwnerNumberTextBox.Text,
                        Email = OwnerEmailTextBox.Text
                    };

                    _dbContext.Add<Owner>(animalOwner);
                    _dbContext.SaveChanges();

                    Animal animalToAdd = new Animal()
                    {
                        Name = AnimalNameTextBox.Text,
                        Breed = AnimalBreedTextBox.Text,
                        Species = AnimalSepciesTextBox.Text,
                        Age = Convert.ToInt16(AnimalAgeTextBox.Text),
                        OwnerId = animalOwner.Id
                    };

                    _dbContext.Add<Animal>(animalToAdd);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Animal info added successfully to the database.");
                    DataUpdated?.Invoke();
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadData()
        {
            if (_animal != null && _owner != null)
            {
                AnimalNameTextBox.Text = _animal.Name;
            }
            else
            {
                MessageBox.Show("Something went wrong; could not load data");
            }
        }
    }
}

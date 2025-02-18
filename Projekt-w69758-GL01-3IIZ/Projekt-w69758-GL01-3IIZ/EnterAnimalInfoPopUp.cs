using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_w69758_GL01_3IIZ.Models;

namespace Projekt_w69758_GL01_3IIZ
{
    public partial class EnterAnimalInfoPopUp : Form
    {
        private DBManager _dbContext;

        public event Action? DataUpdated;

        public EnterAnimalInfoPopUp()
        {
            InitializeComponent();
            _dbContext = new DBManager();
        }

        private void EnterAnimalInfo_Click(object sender, EventArgs e)
        {
            try 
            {
                Owner? existingOwner = _dbContext.Owners
                        .FirstOrDefault(o => o.FirstName == OwnerFNameTextBox.Text 
                                            && o.LastName == OwnerFNameTextBox.Text
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
                    this.Close();
                }
                else
                {
                    Owner animalOwner = new Owner()
                    {
                        FirstName = OwnerFNameTextBox.Text,
                        LastName = OwnerFNameTextBox.Text,
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
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

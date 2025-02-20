using Projekt_w69758_GL01_3IIZ.DbFunctionality;
using Projekt_w69758_GL01_3IIZ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_w69758_GL01_3IIZ.EditFunctionality
{
    public partial class EditAnimalInfoPopUp : Form
    {
        private Animal? _animal;
        private Owner? _owner;

        public event Action? DataUpdated;

        public EditAnimalInfoPopUp(Animal animal, Owner owner)
        {
            InitializeComponent();
            _animal = animal;
            _owner = owner;
            LoadData();
        }

        private void UpdateAnimalInfo_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBManager dbContext = new DBManager())
                {
                    Animal? animalToUpdate = dbContext.Animals.FirstOrDefault(a => a.Id == _animal.Id);
                    Owner? animalOwner = dbContext.Owners.FirstOrDefault(o => o.Id == _owner.Id);

                    if (animalToUpdate != null && animalOwner != null)
                    {
                        animalToUpdate.Name = AnimalNameTextBox.Text;
                        animalToUpdate.Breed = AnimalBreedTextBox.Text;
                        animalToUpdate.Species = AnimalSepciesTextBox.Text;
                        animalToUpdate.Age = Convert.ToInt16(AnimalAgeTextBox.Text);

                        animalOwner.FirstName = OwnerFNameTextBox.Text;
                        animalOwner.LastName = OwnerLNameTextBox.Text;
                        animalOwner.TelephoneNumber = OwnerTelNumber.Text;
                        animalOwner.Email = OwnerEmailTextBox.Text;

                        dbContext.SaveChanges();

                        MessageBox.Show("Dane zostały zaktualizowane");
                        DataUpdated?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Właściciel albo zwierzak jest null");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void LoadData()
        {
            MessageBox.Show(_animal.ToString());
            MessageBox.Show(_owner.ToString());

            if (_animal != null && _owner != null)
            {
                AnimalNameTextBox.Text = _animal.Name;
                AnimalSepciesTextBox.Text = _animal.Species;
                AnimalBreedTextBox.Text = _animal.Breed;
                AnimalAgeTextBox.Text = _animal.Age.ToString();

                OwnerFNameTextBox.Text = _owner.FirstName;
                OwnerLNameTextBox.Text = _owner.LastName;
                OwnerNumberTextBox.Text = _owner.TelephoneNumber;
                OwnerEmailTextBox.Text = _owner.Email;
            }
            else
            {
                MessageBox.Show("Something went wrong; could not load data");
                this.Close();
            }
        }
    }
}

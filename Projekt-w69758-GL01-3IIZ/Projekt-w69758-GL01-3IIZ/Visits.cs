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
    public partial class Visits : UserControl
    {
        private DBManager _dbManager;
        public Visits()
        {
            InitializeComponent();
            _dbManager = new DBManager();
        }

        private void Visits_Load(object sender, EventArgs e)
        {
            LoadVisitData(_dbManager);
        }

        private void AnimalSepciesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVisitButton_Click(object sender, EventArgs e)
        {
            Form visitData = new EnterVisitInfoPopUp();
            visitData.Show();
        }

        private void EditVisitButton_Click(object sender, EventArgs e)
        {
            Form visitData = new EnterVisitInfoPopUp();
            visitData.Show();
        }

        private void DeleteVisitButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadVisitData(DBManager dbContext) 
        {
            var visits = dbContext.Visits.ToList();
            if (visits.Any())
            {
                VisitDataGrid.DataSource = visits;
            }
            else
            {
                MessageBox.Show("Brak danych wizyt.");
            }
        }
    }
}

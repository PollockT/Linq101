using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqLibrary;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        private List<Person> people = ListManager.LoadSampleData();

        public Dashboard()
        {
            InitializeComponent();

            InitializeBindings();
        }

        private void InitializeBindings() 
        {
            dropDownBox.DataSource = null;

            dropDownBox.DataSource = people;
            dropDownBox.DisplayMember = "FullName";

           
        }
        
        private void UpdateBindings()
        {

        }

        private void dropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)dropDownBox.SelectedItem;

            YearsExperienceUpDown.Value = selectedPerson.YearsExperience;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)dropDownBox.SelectedItem;

            selectedPerson.YearsExperience = Convert.ToInt32(YearsExperienceUpDown.Value);

            UpdateBindings();
        }
    }
}

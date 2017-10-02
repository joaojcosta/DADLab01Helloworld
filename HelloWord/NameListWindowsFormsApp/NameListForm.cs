using System;
using System.Windows.Forms;

namespace NameListWindowsFormsApp
{
    public partial class NameListForm : Form
    {
        private INameList nameList = null;

        public NameListForm()
        {
            InitializeComponent();
            nameList = new NameList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var name = NameTextBox.Text;
            if(!nameList.Add(name) || String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name duplicated or empty!!!!","Invalid name",MessageBoxButtons.OK);
            }
            NameTextBox.Text = "";
            NameTextBox.Focus();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            string names = nameList.GetNames(); 
            if(names != null)
            {
                ListTextBox.Text = names;
            }
            else
            {
                MessageBox.Show(
                    "Not exist names to display in this moment.",
                    "Empty",
                    MessageBoxButtons.OK
                    );
            }           
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            if(!nameList.Erasing())
            {
                MessageBox.Show("List just is empty","List empty",MessageBoxButtons.OK);
            }
            else
            {
                ListTextBox.Text = "";
            }
        }
    }
}

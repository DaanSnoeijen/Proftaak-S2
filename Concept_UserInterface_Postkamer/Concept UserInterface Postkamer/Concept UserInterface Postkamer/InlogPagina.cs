using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concept_UserInterface_Postkamer
{
    public partial class InlogPagina : Form
    {
        public InlogPagina()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if (GebruikersNaamBox.Text == "Admin"&&WachtwoordBox.Text=="Admin")
            {
                this.Hide();
                GebuikersMenu GebruikersMenuForm = new GebuikersMenu(this);
                GebruikersMenuForm.ShowDialog();
            }
        }
    }
}

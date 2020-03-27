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
    public partial class GebuikersMenu : Form
    {
        InlogPagina inlogPage;
        public GebuikersMenu(InlogPagina Inlog)
        {
            InitializeComponent();
            inlogPage = Inlog;
        }

        private void OpneemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToevoegenBestelling ToevoegenForm = new ToevoegenBestelling(this);
            ToevoegenForm.ShowDialog();
        }

        private void BekijkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellingen BestellingenForm = new Bestellingen(this);
            BestellingenForm.ShowDialog();
        }

        private void UitlogButton_Click(object sender, EventArgs e)
        {
            this.Close();
            inlogPage.Show();
        }
    }
}

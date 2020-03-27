using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostkamerDatabaseLibrary;

namespace Concept_UserInterface_Postkamer
{
    public partial class ToevoegenBestelling : Form
    {
        GebuikersMenu GebruikMenu;
        public ToevoegenBestelling(GebuikersMenu GMenu)
        {
            InitializeComponent();
            GebruikMenu = GMenu;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GebruikMenu.Show();
        }

        private void ToevoegButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox toegevoegd = new CustomMessageBox("Bestelling Toegevoegd", "Pakket ID:", "Nieuw Pakket", "Hoofdmenu");
            toegevoegd.StartPosition = FormStartPosition.CenterParent;
            toegevoegd.ShowDialog();

            Geaddresseerde g = new Geaddresseerde(1, "bob", "china", "dead", true);
            Medewerker m = new Medewerker(1, "bob2", MedewerkerType.Medewerker);
            Afzender a = new Afzender(1, "bob3", "china", "dead", "1234AB");

            Pakket p = new Pakket(Convert.ToInt32(textBox4.Text), textBox1.Text, textBox7.Text, Convert.ToDateTime(dateTimePicker1.Value), g, m, a, true, false);
        }
    }
}
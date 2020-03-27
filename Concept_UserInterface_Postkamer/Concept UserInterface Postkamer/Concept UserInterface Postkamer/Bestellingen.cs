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
    public partial class Bestellingen : Form
    {
        GebuikersMenu GebruikMenu;
        public Bestellingen(GebuikersMenu GMenu)
        {
            InitializeComponent();
            GebruikMenu = GMenu;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GebruikMenu.Show();
        }

        private void grpbx1Verwijderbutton_Click(object sender, EventArgs e)
        {
            CustomMessageBox VerwijderBox = new CustomMessageBox("Verwijderen", "Weet je zeker dat je PakketID: R7DJ56 wilt verwijderen?", "Annuleren" ,"Verwijderen");
            VerwijderBox.StartPosition = FormStartPosition.CenterParent;
            VerwijderBox.ShowDialog();
        }

        private void grpbox1InfoButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox InfoBox = new CustomMessageBox("Informatie", "PakketID: 8JF94H \nKlantID: 87r5gt \nNaam: Jan Jansen \nAanwezigheid: Aanwezig tot 14:00 \nAfzender: DHL \nStaat: Pakket is in prima staat \nDatum: 04-03-2020 \nIntern: Ja \nAflevering: Nog niet afgeleverd", "Terug");
            InfoBox.StartPosition = FormStartPosition.CenterParent;
            InfoBox.ShowDialog();
        }
        private void grpbox1Wijzigbutton_Click(object sender, EventArgs e)
        {

        }

        private void grpbox1Akkoordbutton_Click(object sender, EventArgs e)
        {
            CustomMessageBox AkkoordBox = new CustomMessageBox("Akkoord", "Naam: Jan Jansen \nOndertekening: \n\n\n\nDatum: 04-03-2020", "Opslaan", "Terug");
            AkkoordBox.StartPosition = FormStartPosition.CenterParent;
            AkkoordBox.ShowDialog();
        }
    }
}

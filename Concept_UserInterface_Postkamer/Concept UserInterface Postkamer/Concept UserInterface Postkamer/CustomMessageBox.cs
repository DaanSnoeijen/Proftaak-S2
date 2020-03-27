using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Concept_UserInterface_Postkamer
{
    public class CustomMessageBox : Form
    {
        Label message = new Label();
        Button b1 = new Button();
        Button b2 = new Button(); 
        TextBox tekst = new TextBox();

        public CustomMessageBox()
        {

        }
        public CustomMessageBox(string title, string body, string button1)
        {
            this.ClientSize = new Size(490, 150);
            this.Text = title;

            b1.Location = new Point(411, 112);
            b1.Size = new Size(75, 23);
            b1.Text = button1;
            b1.BackColor = Control.DefaultBackColor;

            message.Location = new Point(10, 10);
            message.Text = body;
            message.Font = Control.DefaultFont;
            message.AutoSize = true;

            this.BackColor = Color.White;
            this.ShowIcon = false;

            this.Controls.Add(b1);
            this.Controls.Add(message);
        }
        public CustomMessageBox(string title, string body, string button1, string button2)
        {
            this.ClientSize = new Size(490, 150);
            this.Text = title;

            b1.Location = new Point(411, 112);
            b1.Size = new Size(75, 23);
            b1.Text = button1;
            b1.BackColor = Control.DefaultBackColor;

            b2.Location = new Point(311, 112);
            b2.Size = new Size(75, 23);
            b2.Text = button2;
            b2.BackColor = Control.DefaultBackColor;

            message.Location = new Point(10, 10);
            message.Text = body;
            message.Font = Control.DefaultFont;
            message.AutoSize = true;

            this.BackColor = Color.White;
            this.ShowIcon = false;

            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(message);

        }
    }
}

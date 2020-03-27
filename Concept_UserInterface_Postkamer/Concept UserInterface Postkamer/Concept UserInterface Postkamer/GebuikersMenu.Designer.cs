namespace Concept_UserInterface_Postkamer
{
    partial class GebuikersMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpneemButton = new System.Windows.Forms.Button();
            this.BekijkButton = new System.Windows.Forms.Button();
            this.UitlogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpneemButton
            // 
            this.OpneemButton.Location = new System.Drawing.Point(12, 12);
            this.OpneemButton.Name = "OpneemButton";
            this.OpneemButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpneemButton.Size = new System.Drawing.Size(300, 60);
            this.OpneemButton.TabIndex = 0;
            this.OpneemButton.Text = "Bestelling toevoegen";
            this.OpneemButton.UseVisualStyleBackColor = true;
            this.OpneemButton.Click += new System.EventHandler(this.OpneemButton_Click);
            // 
            // BekijkButton
            // 
            this.BekijkButton.Location = new System.Drawing.Point(12, 78);
            this.BekijkButton.Name = "BekijkButton";
            this.BekijkButton.Size = new System.Drawing.Size(300, 60);
            this.BekijkButton.TabIndex = 1;
            this.BekijkButton.Text = "Bestellingen bekijken";
            this.BekijkButton.UseVisualStyleBackColor = true;
            this.BekijkButton.Click += new System.EventHandler(this.BekijkButton_Click);
            // 
            // UitlogButton
            // 
            this.UitlogButton.Location = new System.Drawing.Point(212, 144);
            this.UitlogButton.Name = "UitlogButton";
            this.UitlogButton.Size = new System.Drawing.Size(100, 60);
            this.UitlogButton.TabIndex = 2;
            this.UitlogButton.Text = "Uitloggen";
            this.UitlogButton.UseVisualStyleBackColor = true;
            this.UitlogButton.Click += new System.EventHandler(this.UitlogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingelogd als: Gebruiker 001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Functie: Admin";
            // 
            // GebuikersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UitlogButton);
            this.Controls.Add(this.BekijkButton);
            this.Controls.Add(this.OpneemButton);
            this.Name = "GebuikersMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpneemButton;
        private System.Windows.Forms.Button BekijkButton;
        private System.Windows.Forms.Button UitlogButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
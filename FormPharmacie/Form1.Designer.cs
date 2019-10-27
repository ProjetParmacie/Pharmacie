namespace FormPharmacie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuTrackbar1 = new Bunifu.Framework.UI.BunifuTrackbar();
            this.SuspendLayout();
            // 
            // bunifuTrackbar1
            // 
            this.bunifuTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuTrackbar1.BorderRadius = 0;
            this.bunifuTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuTrackbar1.Location = new System.Drawing.Point(58, 245);
            this.bunifuTrackbar1.MaximumValue = 100;
            this.bunifuTrackbar1.MinimumValue = 0;
            this.bunifuTrackbar1.Name = "bunifuTrackbar1";
            this.bunifuTrackbar1.Size = new System.Drawing.Size(466, 30);
            this.bunifuTrackbar1.SliderRadius = 0;
            this.bunifuTrackbar1.TabIndex = 0;
            this.bunifuTrackbar1.Value = 0;
            this.bunifuTrackbar1.ValueChanged += new System.EventHandler(this.BunifuTrackbar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(555, 311);
            this.Controls.Add(this.bunifuTrackbar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTrackbar bunifuTrackbar1;
    }
}


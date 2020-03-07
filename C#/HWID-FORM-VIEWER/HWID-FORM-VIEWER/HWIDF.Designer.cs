namespace HWID_FORM_VIEWER
{
    partial class HWIDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HWIDF));
            this.nyX_Theme = new CS_ClassLibraryTester.NYX_Theme();
            this.nyX_ControlBox1 = new CS_ClassLibraryTester.NYX_ControlBox();
            this.HWID = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.danylf_hwidviewer = new CS_ClassLibraryTester.NYX_Button();
            this.nyX_Theme.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyX_Theme
            // 
            this.nyX_Theme.Animated = true;
            this.nyX_Theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_Theme.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Theme.Controls.Add(this.nyX_ControlBox1);
            this.nyX_Theme.Controls.Add(this.HWID);
            this.nyX_Theme.Controls.Add(this.danylf_hwidviewer);
            this.nyX_Theme.Customization = "";
            this.nyX_Theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nyX_Theme.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_Theme.Image = null;
            this.nyX_Theme.Location = new System.Drawing.Point(0, 0);
            this.nyX_Theme.Movable = true;
            this.nyX_Theme.Name = "nyX_Theme";
            this.nyX_Theme.NoRounding = false;
            this.nyX_Theme.Sizable = true;
            this.nyX_Theme.Size = new System.Drawing.Size(353, 159);
            this.nyX_Theme.SmartBounds = true;
            this.nyX_Theme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nyX_Theme.TabIndex = 0;
            this.nyX_Theme.Text = "HWID-VIEWER";
            this.nyX_Theme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme.Transparent = false;
            // 
            // nyX_ControlBox1
            // 
            this.nyX_ControlBox1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_ControlBox1.Customization = "";
            this.nyX_ControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_ControlBox1.Image = null;
            this.nyX_ControlBox1.Location = new System.Drawing.Point(306, 3);
            this.nyX_ControlBox1.Name = "nyX_ControlBox1";
            this.nyX_ControlBox1.NoRounding = false;
            this.nyX_ControlBox1.Size = new System.Drawing.Size(44, 20);
            this.nyX_ControlBox1.TabIndex = 2;
            this.nyX_ControlBox1.Text = "nyX_ControlBox1";
            this.nyX_ControlBox1.Transparent = false;
            // 
            // HWID
            // 
            this.HWID.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.HWID.Customization = "";
            this.HWID.Font = new System.Drawing.Font("Verdana", 8F);
            this.HWID.Image = null;
            this.HWID.Location = new System.Drawing.Point(12, 45);
            this.HWID.MaxLength = 32767;
            this.HWID.Multiline = false;
            this.HWID.Name = "HWID";
            this.HWID.NoRounding = false;
            this.HWID.ReadOnly = true;
            this.HWID.Size = new System.Drawing.Size(329, 24);
            this.HWID.TabIndex = 1;
            this.HWID.Text = "HWID";
            this.HWID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HWID.Transparent = false;
            this.HWID.UseSystemPasswordChar = false;
            // 
            // danylf_hwidviewer
            // 
            this.danylf_hwidviewer.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.danylf_hwidviewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.danylf_hwidviewer.Customization = "";
            this.danylf_hwidviewer.Font = new System.Drawing.Font("Arial", 8F);
            this.danylf_hwidviewer.Image = null;
            this.danylf_hwidviewer.Location = new System.Drawing.Point(63, 122);
            this.danylf_hwidviewer.Name = "danylf_hwidviewer";
            this.danylf_hwidviewer.NoRounding = false;
            this.danylf_hwidviewer.Size = new System.Drawing.Size(232, 25);
            this.danylf_hwidviewer.TabIndex = 0;
            this.danylf_hwidviewer.Text = "Voir HWID";
            this.danylf_hwidviewer.Transparent = false;
            this.danylf_hwidviewer.Click += new System.EventHandler(this.danylf_hwidviewer_Click);
            // 
            // HWIDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 159);
            this.Controls.Add(this.nyX_Theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HWIDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dany-LF HWID VIEWER";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme nyX_Theme;
        private CS_ClassLibraryTester.NYX_Button danylf_hwidviewer;
        private CS_ClassLibraryTester.CrystalClearTextBox HWID;
        private CS_ClassLibraryTester.NYX_ControlBox nyX_ControlBox1;
    }
}


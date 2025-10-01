namespace LoaderC_
{
    partial class loadscreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadscreen));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            loadGif = new PictureBox();
            loadLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)loadGif).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.DragForm = false;
            guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // loadGif
            // 
            loadGif.Image = (Image)resources.GetObject("loadGif.Image");
            loadGif.Location = new Point(111, 108);
            loadGif.Name = "loadGif";
            loadGif.Size = new Size(70, 70);
            loadGif.SizeMode = PictureBoxSizeMode.Zoom;
            loadGif.TabIndex = 0;
            loadGif.TabStop = false;
            // 
            // loadLabel
            // 
            loadLabel.BackColor = Color.Transparent;
            loadLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadLabel.ForeColor = Color.White;
            loadLabel.IsSelectionEnabled = false;
            loadLabel.Location = new Point(120, 182);
            loadLabel.Margin = new Padding(1);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(55, 17);
            loadLabel.TabIndex = 11;
            loadLabel.Text = "Loading...";
            // 
            // loadscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(300, 300);
            Controls.Add(loadLabel);
            Controls.Add(loadGif);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loadscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gamelock";
            Load += loadscreen_Load;
            ((System.ComponentModel.ISupportInitialize)loadGif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private PictureBox loadGif;
        private Guna.UI2.WinForms.Guna2HtmlLabel loadLabel;
    }
}
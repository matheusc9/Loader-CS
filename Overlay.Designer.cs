namespace LoaderC_
{
    partial class Overlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            title = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)title).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.Image = (Image)resources.GetObject("title.Image");
            title.Location = new Point(12, 12);
            title.Name = "title";
            title.Size = new Size(188, 38);
            title.SizeMode = PictureBoxSizeMode.Zoom;
            title.TabIndex = 12;
            title.TabStop = false;
            // 
            // Overlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Overlay";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            TransparencyKey = Color.FromArgb(64, 0, 64);
            Load += Overlay_Load;
            ((System.ComponentModel.ISupportInitialize)title).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox title;
    }
}
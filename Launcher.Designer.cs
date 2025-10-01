namespace LoaderC_
{
    partial class Launcher
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            usernameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            launchBtn = new Guna.UI2.WinForms.Guna2Button();
            title = new PictureBox();
            guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            licenseLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gameSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            subtitleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)title).BeginInit();
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
            // usernameLabel
            // 
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.IsSelectionEnabled = false;
            usernameLabel.Location = new Point(51, 453);
            usernameLabel.Margin = new Padding(1);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(56, 17);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username";
            // 
            // launchBtn
            // 
            launchBtn.BorderColor = Color.FromArgb(17, 17, 17);
            launchBtn.BorderRadius = 3;
            launchBtn.BorderThickness = 1;
            launchBtn.CustomizableEdges = customizableEdges4;
            launchBtn.DisabledState.BorderColor = Color.FromArgb(30, 30, 30);
            launchBtn.DisabledState.FillColor = Color.FromArgb(20, 20, 20);
            launchBtn.Enabled = false;
            launchBtn.FillColor = Color.FromArgb(10, 10, 10);
            launchBtn.Font = new Font("Segoe UI", 9F);
            launchBtn.ForeColor = Color.White;
            launchBtn.HoverState.BorderColor = Color.FromArgb(19, 19, 19);
            launchBtn.HoverState.FillColor = Color.FromArgb(17, 17, 17);
            launchBtn.Location = new Point(297, 452);
            launchBtn.Margin = new Padding(5);
            launchBtn.Name = "launchBtn";
            launchBtn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            launchBtn.Size = new Size(189, 34);
            launchBtn.TabIndex = 12;
            launchBtn.Text = "🡣 Launch";
            launchBtn.Click += launchBtn_Click;
            // 
            // title
            // 
            title.Image = (Image)resources.GetObject("title.Image");
            title.Location = new Point(21, 12);
            title.Name = "title";
            title.Size = new Size(459, 123);
            title.SizeMode = PictureBoxSizeMode.StretchImage;
            title.TabIndex = 14;
            title.TabStop = false;
            // 
            // guna2Shapes1
            // 
            guna2Shapes1.BorderColor = Color.FromArgb(64, 64, 64);
            guna2Shapes1.BorderThickness = 1;
            guna2Shapes1.FillColor = Color.Black;
            guna2Shapes1.Location = new Point(12, 453);
            guna2Shapes1.Name = "guna2Shapes1";
            guna2Shapes1.PolygonSkip = 1;
            guna2Shapes1.Rotate = 0F;
            guna2Shapes1.RoundedEdges = customizableEdges3;
            guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            guna2Shapes1.Size = new Size(35, 35);
            guna2Shapes1.TabIndex = 15;
            guna2Shapes1.Text = "guna2Shapes1";
            guna2Shapes1.Zoom = 100;
            // 
            // licenseLabel
            // 
            licenseLabel.BackColor = Color.Transparent;
            licenseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            licenseLabel.ForeColor = Color.Gray;
            licenseLabel.IsSelectionEnabled = false;
            licenseLabel.Location = new Point(51, 469);
            licenseLabel.Margin = new Padding(1);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new Size(73, 17);
            licenseLabel.TabIndex = 16;
            licenseLabel.Text = "Never expires";
            // 
            // gameSelect
            // 
            gameSelect.BackColor = Color.Transparent;
            gameSelect.BorderColor = Color.FromArgb(20, 20, 20);
            gameSelect.CustomizableEdges = customizableEdges1;
            gameSelect.DrawMode = DrawMode.OwnerDrawFixed;
            gameSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            gameSelect.FillColor = Color.Black;
            gameSelect.FocusedColor = Color.FromArgb(64, 64, 64);
            gameSelect.FocusedState.BorderColor = Color.FromArgb(64, 64, 64);
            gameSelect.Font = new Font("Segoe UI", 10F);
            gameSelect.ForeColor = Color.White;
            gameSelect.ItemHeight = 30;
            gameSelect.Items.AddRange(new object[] { "One-Armed Robber", "The Forest", "Overlay" });
            gameSelect.Location = new Point(21, 165);
            gameSelect.Name = "gameSelect";
            gameSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gameSelect.Size = new Size(459, 36);
            gameSelect.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            gameSelect.TabIndex = 17;
            gameSelect.SelectedIndexChanged += gameSelect_SelectedIndexChanged;
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.Transparent;
            guna2Separator1.FillColor = Color.FromArgb(20, 20, 20);
            guna2Separator1.Location = new Point(12, 437);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(476, 10);
            guna2Separator1.TabIndex = 18;
            guna2Separator1.UseTransparentBackground = true;
            // 
            // subtitleLabel
            // 
            subtitleLabel.BackColor = Color.Transparent;
            subtitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtitleLabel.ForeColor = Color.White;
            subtitleLabel.IsSelectionEnabled = false;
            subtitleLabel.Location = new Point(21, 144);
            subtitleLabel.Margin = new Padding(1);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(87, 17);
            subtitleLabel.TabIndex = 19;
            subtitleLabel.Text = "Select the game";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel1.IsSelectionEnabled = false;
            guna2HtmlLabel1.Location = new Point(12, 416);
            guna2HtmlLabel1.Margin = new Padding(1);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(468, 17);
            guna2HtmlLabel1.TabIndex = 20;
            guna2HtmlLabel1.Text = "⚠️Warning: restart your computer before starting other protected games or applications!";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.Gray;
            guna2HtmlLabel2.IsSelectionEnabled = false;
            guna2HtmlLabel2.Location = new Point(21, 205);
            guna2HtmlLabel2.Margin = new Padding(1, 1, 1, 3);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(264, 17);
            guna2HtmlLabel2.TabIndex = 21;
            guna2HtmlLabel2.Text = "Thank's for using Breakchain. Have a good game!";
            // 
            // Launcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(500, 500);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(subtitleLabel);
            Controls.Add(guna2Separator1);
            Controls.Add(gameSelect);
            Controls.Add(licenseLabel);
            Controls.Add(guna2Shapes1);
            Controls.Add(title);
            Controls.Add(launchBtn);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Launcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gamelock";
            Load += Launcher_Load;
            ((System.ComponentModel.ISupportInitialize)title).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameLabel;
        private Guna.UI2.WinForms.Guna2Button launchBtn;
        private PictureBox title;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2HtmlLabel licenseLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox gameSelect;
        private Guna.UI2.WinForms.Guna2HtmlLabel subtitleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
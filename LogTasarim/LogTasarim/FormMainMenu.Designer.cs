using System.Drawing;


namespace LogTasarim
{
    partial class FormMainMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.log_collection_button = new FontAwesome.Sharp.IconButton();
            this.log_parsing_button = new FontAwesome.Sharp.IconButton();
            this.log_index_button = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.home_button = new System.Windows.Forms.PictureBox();
            this.minimize_button = new FontAwesome.Sharp.IconButton();
            this.maximize_button = new FontAwesome.Sharp.IconButton();
            this.exit_button = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildeForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildeForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.log_collection_button);
            this.panelMenu.Controls.Add(this.log_parsing_button);
            this.panelMenu.Controls.Add(this.log_index_button);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 729);
            this.panelMenu.TabIndex = 0;
            // 
            // log_collection_button
            // 
            this.log_collection_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_collection_button.FlatAppearance.BorderSize = 0;
            this.log_collection_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_collection_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_collection_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_collection_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_collection_button.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.log_collection_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_collection_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_collection_button.IconSize = 24;
            this.log_collection_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_collection_button.Location = new System.Drawing.Point(0, 260);
            this.log_collection_button.Name = "log_collection_button";
            this.log_collection_button.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.log_collection_button.Rotation = 0D;
            this.log_collection_button.Size = new System.Drawing.Size(220, 60);
            this.log_collection_button.TabIndex = 3;
            this.log_collection_button.Text = "Log Collection";
            this.log_collection_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_collection_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_collection_button.UseVisualStyleBackColor = true;
            this.log_collection_button.Click += new System.EventHandler(this.log_collection_button_Click);
            // 
            // log_parsing_button
            // 
            this.log_parsing_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_parsing_button.FlatAppearance.BorderSize = 0;
            this.log_parsing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_parsing_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_parsing_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_parsing_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_parsing_button.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.log_parsing_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_parsing_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_parsing_button.IconSize = 24;
            this.log_parsing_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_parsing_button.Location = new System.Drawing.Point(0, 200);
            this.log_parsing_button.Name = "log_parsing_button";
            this.log_parsing_button.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.log_parsing_button.Rotation = 0D;
            this.log_parsing_button.Size = new System.Drawing.Size(220, 60);
            this.log_parsing_button.TabIndex = 2;
            this.log_parsing_button.Text = "Log Parsing";
            this.log_parsing_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_parsing_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_parsing_button.UseVisualStyleBackColor = true;
            this.log_parsing_button.Click += new System.EventHandler(this.log_parsing_button_Click);
            // 
            // log_index_button
            // 
            this.log_index_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_index_button.FlatAppearance.BorderSize = 0;
            this.log_index_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_index_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.log_index_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_index_button.ForeColor = System.Drawing.Color.Gainsboro;
            this.log_index_button.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.log_index_button.IconColor = System.Drawing.Color.Gainsboro;
            this.log_index_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log_index_button.IconSize = 24;
            this.log_index_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_index_button.Location = new System.Drawing.Point(0, 140);
            this.log_index_button.Name = "log_index_button";
            this.log_index_button.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.log_index_button.Rotation = 0D;
            this.log_index_button.Size = new System.Drawing.Size(220, 60);
            this.log_index_button.TabIndex = 1;
            this.log_index_button.Text = "Log Indexing";
            this.log_index_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_index_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_index_button.UseVisualStyleBackColor = true;
            this.log_index_button.Click += new System.EventHandler(this.log_index_button_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.home_button);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Gainsboro;
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.Location = new System.Drawing.Point(29, 16);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(158, 105);
            this.home_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_button.TabIndex = 0;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize_button.IconColor = System.Drawing.Color.Black;
            this.minimize_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_button.IconSize = 16;
            this.minimize_button.Location = new System.Drawing.Point(660, 3);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Rotation = 0D;
            this.minimize_button.Size = new System.Drawing.Size(32, 27);
            this.minimize_button.TabIndex = 4;
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click_1);
            // 
            // maximize_button
            // 
            this.maximize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_button.FlatAppearance.BorderSize = 0;
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.maximize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize_button.IconColor = System.Drawing.Color.Black;
            this.maximize_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize_button.IconSize = 16;
            this.maximize_button.Location = new System.Drawing.Point(698, 7);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Rotation = 0D;
            this.maximize_button.Size = new System.Drawing.Size(32, 22);
            this.maximize_button.TabIndex = 3;
            this.maximize_button.UseVisualStyleBackColor = true;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click_1);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exit_button.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exit_button.IconColor = System.Drawing.Color.Black;
            this.exit_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_button.IconSize = 16;
            this.exit_button.Location = new System.Drawing.Point(736, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Rotation = 0D;
            this.exit_button.Size = new System.Drawing.Size(26, 30);
            this.exit_button.TabIndex = 2;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click_1);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(55, 49);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(38, 15);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildeForm
            // 
            this.iconCurrentChildeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildeForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildeForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildeForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildeForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildeForm.Location = new System.Drawing.Point(22, 41);
            this.iconCurrentChildeForm.Name = "iconCurrentChildeForm";
            this.iconCurrentChildeForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildeForm.TabIndex = 0;
            this.iconCurrentChildeForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(788, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 9);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(788, 720);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.minimize_button);
            this.panelTitleBar.Controls.Add(this.maximize_button);
            this.panelTitleBar.Controls.Add(this.exit_button);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildeForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(788, 100);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Log Yönetimi";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildeForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton log_index_button;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton log_collection_button;
        private FontAwesome.Sharp.IconButton log_parsing_button;
        private System.Windows.Forms.PictureBox home_button;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildeForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton exit_button;
        private FontAwesome.Sharp.IconButton minimize_button;
        private FontAwesome.Sharp.IconButton maximize_button;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}


namespace IHM
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bpFNgoose = new System.Windows.Forms.Button();
            this.bpFNRelais = new System.Windows.Forms.Button();
            this.bpIED = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnCloseChildform = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.bpFNgoose);
            this.panelMenu.Controls.Add(this.bpFNRelais);
            this.panelMenu.Controls.Add(this.bpIED);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(412, 1102);
            this.panelMenu.TabIndex = 0;
            // 
            // bpFNgoose
            // 
            this.bpFNgoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.bpFNgoose.FlatAppearance.BorderSize = 0;
            this.bpFNgoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bpFNgoose.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpFNgoose.ForeColor = System.Drawing.Color.White;
            this.bpFNgoose.Image = ((System.Drawing.Image)(resources.GetObject("bpFNgoose.Image")));
            this.bpFNgoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bpFNgoose.Location = new System.Drawing.Point(0, 541);
            this.bpFNgoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bpFNgoose.Name = "bpFNgoose";
            this.bpFNgoose.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bpFNgoose.Size = new System.Drawing.Size(412, 189);
            this.bpFNgoose.TabIndex = 3;
            this.bpFNgoose.Text = "Goose";
            this.bpFNgoose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bpFNgoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bpFNgoose.UseVisualStyleBackColor = true;
            this.bpFNgoose.Click += new System.EventHandler(this.bpFNgoose_Click);
            // 
            // bpFNRelais
            // 
            this.bpFNRelais.Dock = System.Windows.Forms.DockStyle.Top;
            this.bpFNRelais.FlatAppearance.BorderSize = 0;
            this.bpFNRelais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bpFNRelais.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpFNRelais.ForeColor = System.Drawing.Color.White;
            this.bpFNRelais.Image = ((System.Drawing.Image)(resources.GetObject("bpFNRelais.Image")));
            this.bpFNRelais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bpFNRelais.Location = new System.Drawing.Point(0, 350);
            this.bpFNRelais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bpFNRelais.Name = "bpFNRelais";
            this.bpFNRelais.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bpFNRelais.Size = new System.Drawing.Size(412, 191);
            this.bpFNRelais.TabIndex = 2;
            this.bpFNRelais.Text = "Relays";
            this.bpFNRelais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bpFNRelais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bpFNRelais.UseVisualStyleBackColor = true;
            this.bpFNRelais.Click += new System.EventHandler(this.bpFNRelais_Click);
            // 
            // bpIED
            // 
            this.bpIED.Dock = System.Windows.Forms.DockStyle.Top;
            this.bpIED.FlatAppearance.BorderSize = 0;
            this.bpIED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bpIED.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpIED.ForeColor = System.Drawing.Color.White;
            this.bpIED.Image = ((System.Drawing.Image)(resources.GetObject("bpIED.Image")));
            this.bpIED.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bpIED.Location = new System.Drawing.Point(0, 164);
            this.bpIED.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bpIED.Name = "bpIED";
            this.bpIED.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bpIED.Size = new System.Drawing.Size(412, 186);
            this.bpIED.TabIndex = 1;
            this.bpIED.Text = "Add IED";
            this.bpIED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bpIED.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bpIED.UseVisualStyleBackColor = true;
            this.bpIED.Click += new System.EventHandler(this.bpIED_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(412, 164);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "IEC 61850 - IHM";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnclose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildform);
            this.panelTitleBar.Controls.Add(this.lbltitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(412, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1534, 164);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.Lime;
            this.btnMinimize.Location = new System.Drawing.Point(1398, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 55);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.Yellow;
            this.btnMaximize.Location = new System.Drawing.Point(1434, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(46, 55);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclose.ForeColor = System.Drawing.Color.Red;
            this.btnclose.Location = new System.Drawing.Point(1472, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(46, 55);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "O";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCloseChildform
            // 
            this.btnCloseChildform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildform.FlatAppearance.BorderSize = 0;
            this.btnCloseChildform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildform.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildform.Image")));
            this.btnCloseChildform.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseChildform.Name = "btnCloseChildform";
            this.btnCloseChildform.Size = new System.Drawing.Size(221, 164);
            this.btnCloseChildform.TabIndex = 1;
            this.btnCloseChildform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseChildform.UseVisualStyleBackColor = true;
            this.btnCloseChildform.Click += new System.EventHandler(this.btnCloseChildform_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(600, 55);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(216, 46);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Main Menu";
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(412, 164);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1534, 938);
            this.panelDesktop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(689, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 53);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semestre P2022";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(395, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(792, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "Réalisé par : Hugo TEANI et Sébastien HIRTH";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(296, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(953, 53);
            this.label3.TabIndex = 1;
            this.label3.Text = "TO54 - Réalisation d\'une IHM selon la norme IEC 61850";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1946, 1102);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "Menu";
            this.Text = "IHM - IEC 61850";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.SizeChanged += new System.EventHandler(this.Menu_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button bpIED;
        private Button bpFNgoose;
        private Button bpFNRelais;
        private Panel panelTitleBar;
        private Label lbltitle;
        private Label label1;
        private Panel panelDesktop;
        private Button btnCloseChildform;
        private Label label3;
        private Label label2;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnclose;
        private Label label4;
    }
}
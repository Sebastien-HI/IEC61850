namespace IHM.Forms
{
    partial class Chargement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chargement));
            this.label_statut = new System.Windows.Forms.Label();
            this.progressBar_statut = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_statut
            // 
            this.label_statut.AutoSize = true;
            this.label_statut.Location = new System.Drawing.Point(285, 154);
            this.label_statut.Name = "label_statut";
            this.label_statut.Size = new System.Drawing.Size(37, 25);
            this.label_statut.TabIndex = 5;
            this.label_statut.Text = "0%";
            // 
            // progressBar_statut
            // 
            this.progressBar_statut.Location = new System.Drawing.Point(21, 85);
            this.progressBar_statut.Maximum = 101;
            this.progressBar_statut.Name = "progressBar_statut";
            this.progressBar_statut.Size = new System.Drawing.Size(580, 34);
            this.progressBar_statut.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_statut.TabIndex = 4;
            this.progressBar_statut.Click += new System.EventHandler(this.progressBar_statut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trying to Connect to IED, please wait";
            // 
            // Chargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(638, 195);
            this.Controls.Add(this.label_statut);
            this.Controls.Add(this.progressBar_statut);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chargement";
            this.Text = "Connection in Progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ProgressBar progressBar_statut;
        public Label label_statut;
        public Label label1;
    }
}
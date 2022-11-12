namespace IHM.Forms
{
    partial class FNGoose
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
            this.components = new System.ComponentModel.Container();
            this.ExpoExcel = new System.Windows.Forms.Button();
            this.ViderGoose = new System.Windows.Forms.Button();
            this.SupprimerGoose = new System.Windows.Forms.Button();
            this.GridGoose = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_IED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defaut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phase_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phase_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phase_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_goose = new System.Windows.Forms.Timer(this.components);
            this.Button_Start = new System.Windows.Forms.Button();
            this.InterfaceID_list = new System.Windows.Forms.CheckedListBox();
            this.Label_InterfaceID = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.ON_OFF_Label = new System.Windows.Forms.Label();
            this.Boutton_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridGoose)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpoExcel
            // 
            this.ExpoExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpoExcel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpoExcel.Location = new System.Drawing.Point(1063, 557);
            this.ExpoExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExpoExcel.Name = "ExpoExcel";
            this.ExpoExcel.Size = new System.Drawing.Size(267, 70);
            this.ExpoExcel.TabIndex = 9;
            this.ExpoExcel.Text = "To Excel";
            this.ExpoExcel.UseVisualStyleBackColor = true;
            this.ExpoExcel.Click += new System.EventHandler(this.ExpoExcel_Click);
            // 
            // ViderGoose
            // 
            this.ViderGoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViderGoose.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViderGoose.Location = new System.Drawing.Point(704, 557);
            this.ViderGoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViderGoose.Name = "ViderGoose";
            this.ViderGoose.Size = new System.Drawing.Size(246, 70);
            this.ViderGoose.TabIndex = 8;
            this.ViderGoose.Text = "Empty";
            this.ViderGoose.UseVisualStyleBackColor = true;
            this.ViderGoose.Click += new System.EventHandler(this.ViderGoose_Click);
            // 
            // SupprimerGoose
            // 
            this.SupprimerGoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SupprimerGoose.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SupprimerGoose.Location = new System.Drawing.Point(363, 557);
            this.SupprimerGoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SupprimerGoose.Name = "SupprimerGoose";
            this.SupprimerGoose.Size = new System.Drawing.Size(246, 70);
            this.SupprimerGoose.TabIndex = 7;
            this.SupprimerGoose.Text = "Delete";
            this.SupprimerGoose.UseVisualStyleBackColor = true;
            this.SupprimerGoose.Click += new System.EventHandler(this.SupprimerGoose_Click);
            // 
            // GridGoose
            // 
            this.GridGoose.AllowUserToAddRows = false;
            this.GridGoose.AllowUserToDeleteRows = false;
            this.GridGoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GridGoose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridGoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGoose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Time,
            this.Nom_IED,
            this.Defaut,
            this.Phase_1,
            this.Phase_2,
            this.Phase_3});
            this.GridGoose.Location = new System.Drawing.Point(294, 235);
            this.GridGoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GridGoose.Name = "GridGoose";
            this.GridGoose.ReadOnly = true;
            this.GridGoose.RowHeadersWidth = 51;
            this.GridGoose.RowTemplate.Height = 29;
            this.GridGoose.Size = new System.Drawing.Size(1219, 258);
            this.GridGoose.TabIndex = 6;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Numero.HeaderText = "N°";
            this.Numero.MinimumWidth = 8;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 68;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 86;
            // 
            // Nom_IED
            // 
            this.Nom_IED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nom_IED.HeaderText = "Name IED";
            this.Nom_IED.MinimumWidth = 6;
            this.Nom_IED.Name = "Nom_IED";
            this.Nom_IED.ReadOnly = true;
            this.Nom_IED.Width = 127;
            // 
            // Defaut
            // 
            this.Defaut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Defaut.HeaderText = "Type of default ";
            this.Defaut.MinimumWidth = 6;
            this.Defaut.Name = "Defaut";
            this.Defaut.ReadOnly = true;
            this.Defaut.Width = 172;
            // 
            // Phase_1
            // 
            this.Phase_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phase_1.HeaderText = "Phase 1";
            this.Phase_1.MinimumWidth = 6;
            this.Phase_1.Name = "Phase_1";
            this.Phase_1.ReadOnly = true;
            this.Phase_1.Width = 109;
            // 
            // Phase_2
            // 
            this.Phase_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phase_2.HeaderText = "Phase 2";
            this.Phase_2.MinimumWidth = 6;
            this.Phase_2.Name = "Phase_2";
            this.Phase_2.ReadOnly = true;
            this.Phase_2.Width = 109;
            // 
            // Phase_3
            // 
            this.Phase_3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phase_3.HeaderText = "Phase 3";
            this.Phase_3.MinimumWidth = 6;
            this.Phase_3.Name = "Phase_3";
            this.Phase_3.ReadOnly = true;
            this.Phase_3.Width = 109;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(389, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Goose Message - IEC 61850";
            // 
            // timer_goose
            // 
            this.timer_goose.Interval = 50;
            this.timer_goose.Tick += new System.EventHandler(this.timer_goose_Tick);
            // 
            // Button_Start
            // 
            this.Button_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Start.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Start.Location = new System.Drawing.Point(46, 557);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(246, 70);
            this.Button_Start.TabIndex = 11;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // InterfaceID_list
            // 
            this.InterfaceID_list.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InterfaceID_list.FormattingEnabled = true;
            this.InterfaceID_list.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.InterfaceID_list.Location = new System.Drawing.Point(99, 298);
            this.InterfaceID_list.Name = "InterfaceID_list";
            this.InterfaceID_list.Size = new System.Drawing.Size(90, 144);
            this.InterfaceID_list.TabIndex = 12;
            this.InterfaceID_list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Label_InterfaceID
            // 
            this.Label_InterfaceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_InterfaceID.AutoSize = true;
            this.Label_InterfaceID.Location = new System.Drawing.Point(27, 235);
            this.Label_InterfaceID.Name = "Label_InterfaceID";
            this.Label_InterfaceID.Size = new System.Drawing.Size(255, 25);
            this.Label_InterfaceID.TabIndex = 13;
            this.Label_InterfaceID.Text = "Please choose your InterfaceID";
            // 
            // label_Status
            // 
            this.label_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Status.Location = new System.Drawing.Point(1119, 57);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(123, 48);
            this.label_Status.TabIndex = 14;
            this.label_Status.Text = "Status:";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ON_OFF_Label
            // 
            this.ON_OFF_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ON_OFF_Label.AutoSize = true;
            this.ON_OFF_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ON_OFF_Label.ForeColor = System.Drawing.Color.Red;
            this.ON_OFF_Label.Location = new System.Drawing.Point(1247, 57);
            this.ON_OFF_Label.Name = "ON_OFF_Label";
            this.ON_OFF_Label.Size = new System.Drawing.Size(83, 48);
            this.ON_OFF_Label.TabIndex = 15;
            this.ON_OFF_Label.Text = "OFF";
            // 
            // Boutton_Stop
            // 
            this.Boutton_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Boutton_Stop.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Boutton_Stop.Location = new System.Drawing.Point(46, 557);
            this.Boutton_Stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boutton_Stop.Name = "Boutton_Stop";
            this.Boutton_Stop.Size = new System.Drawing.Size(246, 70);
            this.Boutton_Stop.TabIndex = 16;
            this.Boutton_Stop.Text = "Stop";
            this.Boutton_Stop.UseVisualStyleBackColor = true;
            this.Boutton_Stop.Visible = false;
            this.Boutton_Stop.Click += new System.EventHandler(this.Boutton_Stop_Click);
            // 
            // FNGoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1479, 708);
            this.Controls.Add(this.Boutton_Stop);
            this.Controls.Add(this.ON_OFF_Label);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.Label_InterfaceID);
            this.Controls.Add(this.InterfaceID_list);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.ExpoExcel);
            this.Controls.Add(this.ViderGoose);
            this.Controls.Add(this.SupprimerGoose);
            this.Controls.Add(this.GridGoose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FNGoose";
            this.Text = "FNGoose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridGoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ExpoExcel;
        private Button ViderGoose;
        private Button SupprimerGoose;
        private DataGridView GridGoose;
        private Label label1;
        private System.Windows.Forms.Timer timer_goose;
        private Button Button_Start;
        private CheckedListBox InterfaceID_list;
        private Label Label_InterfaceID;
        private Label label_Status;
        private Label ON_OFF_Label;
        private Button Boutton_Stop;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Nom_IED;
        private DataGridViewTextBoxColumn Defaut;
        private DataGridViewTextBoxColumn Phase_1;
        private DataGridViewTextBoxColumn Phase_2;
        private DataGridViewTextBoxColumn Phase_3;
    }
}
namespace WindowsFormsApp1
{
    partial class Mauslager
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewMaus = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hersteller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraTasten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HatRad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zustand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBox = new System.Windows.Forms.MaskedTextBox();
            this.HerstellerBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TastenBox = new System.Windows.Forms.NumericUpDown();
            this.RadBox = new System.Windows.Forms.CheckBox();
            this.ZustandBox = new System.Windows.Forms.ComboBox();
            this.VerbindungBox = new System.Windows.Forms.ComboBox();
            this.searchItem = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TastenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(550, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Maus hinzufügen";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewMaus
            // 
            this.dataGridViewMaus.AllowUserToAddRows = false;
            this.dataGridViewMaus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Namen,
            this.hersteller,
            this.extraTasten,
            this.HatRad,
            this.Zustand});
            this.dataGridViewMaus.Location = new System.Drawing.Point(79, 134);
            this.dataGridViewMaus.Name = "dataGridViewMaus";
            this.dataGridViewMaus.Size = new System.Drawing.Size(645, 304);
            this.dataGridViewMaus.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Namen
            // 
            this.Namen.HeaderText = "Namen";
            this.Namen.Name = "Namen";
            // 
            // hersteller
            // 
            this.hersteller.HeaderText = "Hersteller";
            this.hersteller.Name = "hersteller";
            // 
            // extraTasten
            // 
            this.extraTasten.HeaderText = "extra Tasten";
            this.extraTasten.Name = "extraTasten";
            // 
            // HatRad
            // 
            this.HatRad.HeaderText = "Rad";
            this.HatRad.Name = "HatRad";
            // 
            // Zustand
            // 
            this.Zustand.HeaderText = "Zustand";
            this.Zustand.Name = "Zustand";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(214, 36);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 5;
            // 
            // HerstellerBox
            // 
            this.HerstellerBox.Location = new System.Drawing.Point(320, 36);
            this.HerstellerBox.Name = "HerstellerBox";
            this.HerstellerBox.Size = new System.Drawing.Size(100, 20);
            this.HerstellerBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hersteller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "extra Tasten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mausrad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Verbindung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zustand";
            // 
            // TastenBox
            // 
            this.TastenBox.Location = new System.Drawing.Point(434, 36);
            this.TastenBox.Name = "TastenBox";
            this.TastenBox.Size = new System.Drawing.Size(100, 20);
            this.TastenBox.TabIndex = 17;
            // 
            // RadBox
            // 
            this.RadBox.AutoSize = true;
            this.RadBox.Checked = true;
            this.RadBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadBox.Location = new System.Drawing.Point(214, 93);
            this.RadBox.Name = "RadBox";
            this.RadBox.Size = new System.Drawing.Size(100, 17);
            this.RadBox.TabIndex = 18;
            this.RadBox.Text = "Rad vorhanden";
            this.RadBox.UseVisualStyleBackColor = true;
            // 
            // ZustandBox
            // 
            this.ZustandBox.FormattingEnabled = true;
            this.ZustandBox.Items.AddRange(new object[] {
            "Neu",
            "Gut",
            "OK",
            "Gebrauchsspuren"});
            this.ZustandBox.Location = new System.Drawing.Point(434, 93);
            this.ZustandBox.Name = "ZustandBox";
            this.ZustandBox.Size = new System.Drawing.Size(100, 21);
            this.ZustandBox.TabIndex = 19;
            // 
            // VerbindungBox
            // 
            this.VerbindungBox.FormattingEnabled = true;
            this.VerbindungBox.Items.AddRange(new object[] {
            "Kabel",
            "Bluetooth",
            "Funk"});
            this.VerbindungBox.Location = new System.Drawing.Point(320, 93);
            this.VerbindungBox.Name = "VerbindungBox";
            this.VerbindungBox.Size = new System.Drawing.Size(100, 21);
            this.VerbindungBox.TabIndex = 20;
            // 
            // searchItem
            // 
            this.searchItem.Location = new System.Drawing.Point(624, 15);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(164, 20);
            this.searchItem.TabIndex = 22;
            this.searchItem.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // Mauslager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.VerbindungBox);
            this.Controls.Add(this.ZustandBox);
            this.Controls.Add(this.RadBox);
            this.Controls.Add(this.TastenBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HerstellerBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.dataGridViewMaus);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Mauslager";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mauslager";
            this.Load += new System.EventHandler(this.Mauslager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TastenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.DataGridView dataGridViewMaus;
        private System.Windows.Forms.MaskedTextBox NameBox;
        private System.Windows.Forms.MaskedTextBox HerstellerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TastenBox;
        private System.Windows.Forms.CheckBox RadBox;
        private System.Windows.Forms.ComboBox ZustandBox;
        private System.Windows.Forms.ComboBox VerbindungBox;
        private System.Windows.Forms.MaskedTextBox searchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namen;
        private System.Windows.Forms.DataGridViewTextBoxColumn hersteller;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraTasten;
        private System.Windows.Forms.DataGridViewTextBoxColumn HatRad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zustand;
    }
}


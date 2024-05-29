namespace EventAdminApp.Views
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.PriorBox = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SortDate = new System.Windows.Forms.Button();
            this.SortPrior = new System.Windows.Forms.Button();
            this.SortType = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PriorBoxFilter = new System.Windows.Forms.ComboBox();
            this.TypeBoxFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateBoxFilter = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.FilterDate = new System.Windows.Forms.Button();
            this.FilterPrior = new System.Windows.Forms.Button();
            this.FilterType = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonSave.Location = new System.Drawing.Point(27, 326);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 28);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.serialize_list);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.PriorBox);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TypeBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(545, 385);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane wydarzenia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonLoad.Location = new System.Drawing.Point(196, 326);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(145, 28);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Wczytaj";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.deserialize_list);
            // 
            // PriorBox
            // 
            this.PriorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorBox.FormattingEnabled = true;
            this.PriorBox.Items.AddRange(new object[] {
            "Niski",
            "Średni",
            "Wysoki"});
            this.PriorBox.Location = new System.Drawing.Point(168, 236);
            this.PriorBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriorBox.Name = "PriorBox";
            this.PriorBox.Size = new System.Drawing.Size(343, 24);
            this.PriorBox.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonDelete.Location = new System.Drawing.Point(365, 326);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 28);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.deleteEvent);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 287);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(484, 28);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.addEvent);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Priorytet:";
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Rozrywka",
            "Sport",
            "Zdrowie",
            "Inny"});
            this.TypeBox.Location = new System.Drawing.Point(168, 186);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(343, 24);
            this.TypeBox.TabIndex = 8;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Typ:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(168, 137);
            this.DateBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(343, 22);
            this.DateBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data wystąpienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tytuł:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(168, 87);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(343, 22);
            this.DescriptionBox.TabIndex = 2;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(168, 39);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(343, 22);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SortDate);
            this.groupBox2.Controls.Add(this.SortPrior);
            this.groupBox2.Controls.Add(this.SortType);
            this.groupBox2.Location = new System.Drawing.Point(17, 408);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(544, 82);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sortowanie wydarzeń";
            // 
            // SortDate
            // 
            this.SortDate.Location = new System.Drawing.Point(365, 38);
            this.SortDate.Margin = new System.Windows.Forms.Padding(4);
            this.SortDate.Name = "SortDate";
            this.SortDate.Size = new System.Drawing.Size(145, 28);
            this.SortDate.TabIndex = 2;
            this.SortDate.Text = "Data";
            this.SortDate.UseVisualStyleBackColor = true;
            this.SortDate.Click += new System.EventHandler(this.SortDate_Click);
            // 
            // SortPrior
            // 
            this.SortPrior.Location = new System.Drawing.Point(196, 38);
            this.SortPrior.Margin = new System.Windows.Forms.Padding(4);
            this.SortPrior.Name = "SortPrior";
            this.SortPrior.Size = new System.Drawing.Size(145, 28);
            this.SortPrior.TabIndex = 1;
            this.SortPrior.Text = "Priorytet";
            this.SortPrior.UseVisualStyleBackColor = true;
            this.SortPrior.Click += new System.EventHandler(this.SortPrior_Click);
            // 
            // SortType
            // 
            this.SortType.Location = new System.Drawing.Point(27, 38);
            this.SortType.Margin = new System.Windows.Forms.Padding(4);
            this.SortType.Name = "SortType";
            this.SortType.Size = new System.Drawing.Size(145, 28);
            this.SortType.TabIndex = 0;
            this.SortType.Text = "Typ";
            this.SortType.UseVisualStyleBackColor = true;
            this.SortType.Click += new System.EventHandler(this.SortType_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PriorBoxFilter);
            this.groupBox3.Controls.Add(this.TypeBoxFilter);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DateBoxFilter);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.FilterDate);
            this.groupBox3.Controls.Add(this.FilterPrior);
            this.groupBox3.Controls.Add(this.FilterType);
            this.groupBox3.Location = new System.Drawing.Point(17, 498);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(544, 226);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrowanie wydarzeń";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // PriorBoxFilter
            // 
            this.PriorBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorBoxFilter.FormattingEnabled = true;
            this.PriorBoxFilter.Items.AddRange(new object[] {
            "Niski",
            "Średni",
            "Wysoki"});
            this.PriorBoxFilter.Location = new System.Drawing.Point(168, 130);
            this.PriorBoxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.PriorBoxFilter.Name = "PriorBoxFilter";
            this.PriorBoxFilter.Size = new System.Drawing.Size(343, 24);
            this.PriorBoxFilter.TabIndex = 28;
            // 
            // TypeBoxFilter
            // 
            this.TypeBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBoxFilter.FormattingEnabled = true;
            this.TypeBoxFilter.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Rozrywka",
            "Sport",
            "Zdrowie",
            "Inny"});
            this.TypeBoxFilter.Location = new System.Drawing.Point(168, 80);
            this.TypeBoxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.TypeBoxFilter.Name = "TypeBoxFilter";
            this.TypeBoxFilter.Size = new System.Drawing.Size(343, 24);
            this.TypeBoxFilter.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Priorytet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Typ:";
            // 
            // DateBoxFilter
            // 
            this.DateBoxFilter.Location = new System.Drawing.Point(167, 30);
            this.DateBoxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.DateBoxFilter.Name = "DateBoxFilter";
            this.DateBoxFilter.Size = new System.Drawing.Size(343, 22);
            this.DateBoxFilter.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data wystąpienia:";
            // 
            // FilterDate
            // 
            this.FilterDate.Location = new System.Drawing.Point(366, 179);
            this.FilterDate.Margin = new System.Windows.Forms.Padding(4);
            this.FilterDate.Name = "FilterDate";
            this.FilterDate.Size = new System.Drawing.Size(145, 28);
            this.FilterDate.TabIndex = 2;
            this.FilterDate.Text = "Data";
            this.FilterDate.UseVisualStyleBackColor = true;
            this.FilterDate.Click += new System.EventHandler(this.FilterDate_Click);
            // 
            // FilterPrior
            // 
            this.FilterPrior.Location = new System.Drawing.Point(197, 179);
            this.FilterPrior.Margin = new System.Windows.Forms.Padding(4);
            this.FilterPrior.Name = "FilterPrior";
            this.FilterPrior.Size = new System.Drawing.Size(145, 28);
            this.FilterPrior.TabIndex = 1;
            this.FilterPrior.Text = "Priorytet";
            this.FilterPrior.UseVisualStyleBackColor = true;
            this.FilterPrior.Click += new System.EventHandler(this.FilterPrior_Click);
            // 
            // FilterType
            // 
            this.FilterType.Location = new System.Drawing.Point(28, 179);
            this.FilterType.Margin = new System.Windows.Forms.Padding(4);
            this.FilterType.Name = "FilterType";
            this.FilterType.Size = new System.Drawing.Size(145, 28);
            this.FilterType.TabIndex = 0;
            this.FilterType.Text = "Typ";
            this.FilterType.UseVisualStyleBackColor = true;
            this.FilterType.Click += new System.EventHandler(this.FilterType_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(585, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(514, 708);
            this.listBox1.TabIndex = 26;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.selectEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1127, 737);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Wydarzeń";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SortDate;
        private System.Windows.Forms.Button SortPrior;
        private System.Windows.Forms.Button SortType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FilterDate;
        private System.Windows.Forms.Button FilterPrior;
        private System.Windows.Forms.Button FilterType;
        private System.Windows.Forms.ComboBox PriorBox;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox PriorBoxFilter;
        private System.Windows.Forms.ComboBox TypeBoxFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateBoxFilter;
        private System.Windows.Forms.Label label8;
    }
}


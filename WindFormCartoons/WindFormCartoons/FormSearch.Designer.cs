namespace WindFormCartoons
{
    partial class FormSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVSearch = new System.Windows.Forms.DataGridView();
            this.tBCartoonName = new System.Windows.Forms.TextBox();
            this.tBRating = new System.Windows.Forms.TextBox();
            this.tBYear = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.tBDuration = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labele3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRANNOTATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRRATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRCSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICCARTOONSTATUSESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYCARTOONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRACTORSCARTOONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENRECARTOONSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARTOONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTOONSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVSearch);
            this.groupBox1.Location = new System.Drawing.Point(5, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мультфільм за категорією";
            // 
            // dGVSearch
            // 
            this.dGVSearch.AllowUserToOrderColumns = true;
            this.dGVSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSearch.AutoGenerateColumns = false;
            this.dGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRIDDataGridViewTextBoxColumn,
            this.cRNAMEDataGridViewTextBoxColumn,
            this.cRANNOTATIONDataGridViewTextBoxColumn,
            this.cRYEARDataGridViewTextBoxColumn,
            this.cRRATINGDataGridViewTextBoxColumn,
            this.cRDURATIONDataGridViewTextBoxColumn,
            this.cRCSDataGridViewTextBoxColumn,
            this.cRADRESSDataGridViewTextBoxColumn,
            this.dICCARTOONSTATUSESDataGridViewTextBoxColumn,
            this.cOMPANYCARTOONSDataGridViewTextBoxColumn,
            this.dIRACTORSCARTOONSDataGridViewTextBoxColumn,
            this.gENRECARTOONSDataGridViewTextBoxColumn});
            this.dGVSearch.DataSource = this.cARTOONSBindingSource;
            this.dGVSearch.Location = new System.Drawing.Point(0, 19);
            this.dGVSearch.Name = "dGVSearch";
            this.dGVSearch.Size = new System.Drawing.Size(508, 205);
            this.dGVSearch.TabIndex = 0;
            // 
            // tBCartoonName
            // 
            this.tBCartoonName.Location = new System.Drawing.Point(149, 60);
            this.tBCartoonName.Name = "tBCartoonName";
            this.tBCartoonName.Size = new System.Drawing.Size(327, 20);
            this.tBCartoonName.TabIndex = 1;
            // 
            // tBRating
            // 
            this.tBRating.Location = new System.Drawing.Point(149, 86);
            this.tBRating.Name = "tBRating";
            this.tBRating.Size = new System.Drawing.Size(327, 20);
            this.tBRating.TabIndex = 2;
            // 
            // tBYear
            // 
            this.tBYear.Location = new System.Drawing.Point(149, 112);
            this.tBYear.Name = "tBYear";
            this.tBYear.Size = new System.Drawing.Size(327, 20);
            this.tBYear.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(63, 13);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Зберегти";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(184, 12);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Видалити";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(301, 11);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "Пошук";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // tBDuration
            // 
            this.tBDuration.Location = new System.Drawing.Point(149, 138);
            this.tBDuration.Name = "tBDuration";
            this.tBDuration.Size = new System.Drawing.Size(327, 20);
            this.tBDuration.TabIndex = 7;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(16, 60);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(107, 13);
            this.lable1.TabIndex = 8;
            this.lable1.Text = "Назва мультфільму";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(16, 86);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 13);
            this.labelGenre.TabIndex = 9;
            this.labelGenre.Text = "Рейтинг";
            // 
            // labele3
            // 
            this.labele3.AutoSize = true;
            this.labele3.Location = new System.Drawing.Point(16, 112);
            this.labele3.Name = "labele3";
            this.labele3.Size = new System.Drawing.Size(59, 13);
            this.labele3.TabIndex = 10;
            this.labele3.Text = "Рік виходу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Тривалість";
            // 
            // cRIDDataGridViewTextBoxColumn
            // 
            this.cRIDDataGridViewTextBoxColumn.DataPropertyName = "CR_ID";
            this.cRIDDataGridViewTextBoxColumn.HeaderText = "CR_ID";
            this.cRIDDataGridViewTextBoxColumn.Name = "cRIDDataGridViewTextBoxColumn";
            this.cRIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRNAMEDataGridViewTextBoxColumn
            // 
            this.cRNAMEDataGridViewTextBoxColumn.DataPropertyName = "CR_NAME";
            this.cRNAMEDataGridViewTextBoxColumn.HeaderText = "Назва мультфільму";
            this.cRNAMEDataGridViewTextBoxColumn.Name = "cRNAMEDataGridViewTextBoxColumn";
            // 
            // cRANNOTATIONDataGridViewTextBoxColumn
            // 
            this.cRANNOTATIONDataGridViewTextBoxColumn.DataPropertyName = "CR_ANNOTATION";
            this.cRANNOTATIONDataGridViewTextBoxColumn.HeaderText = "Короткий зміст";
            this.cRANNOTATIONDataGridViewTextBoxColumn.Name = "cRANNOTATIONDataGridViewTextBoxColumn";
            // 
            // cRYEARDataGridViewTextBoxColumn
            // 
            this.cRYEARDataGridViewTextBoxColumn.DataPropertyName = "CR_YEAR";
            this.cRYEARDataGridViewTextBoxColumn.HeaderText = "Рік виходу";
            this.cRYEARDataGridViewTextBoxColumn.Name = "cRYEARDataGridViewTextBoxColumn";
            // 
            // cRRATINGDataGridViewTextBoxColumn
            // 
            this.cRRATINGDataGridViewTextBoxColumn.DataPropertyName = "CR_RATING";
            this.cRRATINGDataGridViewTextBoxColumn.HeaderText = "Рейтинг Imdb";
            this.cRRATINGDataGridViewTextBoxColumn.Name = "cRRATINGDataGridViewTextBoxColumn";
            // 
            // cRDURATIONDataGridViewTextBoxColumn
            // 
            this.cRDURATIONDataGridViewTextBoxColumn.DataPropertyName = "CR_DURATION";
            this.cRDURATIONDataGridViewTextBoxColumn.HeaderText = "Тривалість";
            this.cRDURATIONDataGridViewTextBoxColumn.Name = "cRDURATIONDataGridViewTextBoxColumn";
            // 
            // cRCSDataGridViewTextBoxColumn
            // 
            this.cRCSDataGridViewTextBoxColumn.DataPropertyName = "CR_CS";
            this.cRCSDataGridViewTextBoxColumn.HeaderText = "CR_CS";
            this.cRCSDataGridViewTextBoxColumn.Name = "cRCSDataGridViewTextBoxColumn";
            this.cRCSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRADRESSDataGridViewTextBoxColumn
            // 
            this.cRADRESSDataGridViewTextBoxColumn.DataPropertyName = "CR_ADRESS";
            this.cRADRESSDataGridViewTextBoxColumn.HeaderText = "ЛІНК";
            this.cRADRESSDataGridViewTextBoxColumn.Name = "cRADRESSDataGridViewTextBoxColumn";
            // 
            // dICCARTOONSTATUSESDataGridViewTextBoxColumn
            // 
            this.dICCARTOONSTATUSESDataGridViewTextBoxColumn.DataPropertyName = "DIC_CARTOON_STATUSES";
            this.dICCARTOONSTATUSESDataGridViewTextBoxColumn.HeaderText = "DIC_CARTOON_STATUSES";
            this.dICCARTOONSTATUSESDataGridViewTextBoxColumn.Name = "dICCARTOONSTATUSESDataGridViewTextBoxColumn";
            // 
            // cOMPANYCARTOONSDataGridViewTextBoxColumn
            // 
            this.cOMPANYCARTOONSDataGridViewTextBoxColumn.DataPropertyName = "COMPANY_CARTOONS";
            this.cOMPANYCARTOONSDataGridViewTextBoxColumn.HeaderText = "COMPANY_CARTOONS";
            this.cOMPANYCARTOONSDataGridViewTextBoxColumn.Name = "cOMPANYCARTOONSDataGridViewTextBoxColumn";
            this.cOMPANYCARTOONSDataGridViewTextBoxColumn.Visible = false;
            // 
            // dIRACTORSCARTOONSDataGridViewTextBoxColumn
            // 
            this.dIRACTORSCARTOONSDataGridViewTextBoxColumn.DataPropertyName = "DIRACTORS_CARTOONS";
            this.dIRACTORSCARTOONSDataGridViewTextBoxColumn.HeaderText = "DIRACTORS_CARTOONS";
            this.dIRACTORSCARTOONSDataGridViewTextBoxColumn.Name = "dIRACTORSCARTOONSDataGridViewTextBoxColumn";
            this.dIRACTORSCARTOONSDataGridViewTextBoxColumn.Visible = false;
            // 
            // gENRECARTOONSDataGridViewTextBoxColumn
            // 
            this.gENRECARTOONSDataGridViewTextBoxColumn.DataPropertyName = "GENRE_CARTOONS";
            this.gENRECARTOONSDataGridViewTextBoxColumn.HeaderText = "GENRE_CARTOONS";
            this.gENRECARTOONSDataGridViewTextBoxColumn.Name = "gENRECARTOONSDataGridViewTextBoxColumn";
            this.gENRECARTOONSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cARTOONSBindingSource
            // 
            this.cARTOONSBindingSource.DataSource = typeof(ClassCartoons.CARTOONS);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labele3);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.tBDuration);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tBYear);
            this.Controls.Add(this.tBRating);
            this.Controls.Add(this.tBCartoonName);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearch";
            this.Text = "Пошук";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTOONSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBCartoonName;
        private System.Windows.Forms.TextBox tBRating;
        private System.Windows.Forms.TextBox tBYear;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox tBDuration;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labele3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVSearch;
        private System.Windows.Forms.BindingSource cARTOONSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRANNOTATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRRATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRCSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dICCARTOONSTATUSESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYCARTOONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRACTORSCARTOONSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENRECARTOONSDataGridViewTextBoxColumn;
    }
}
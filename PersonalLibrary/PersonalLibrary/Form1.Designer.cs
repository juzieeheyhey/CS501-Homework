namespace PersonalLibrary
{
    partial class Form1
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
            this.grpAddEntry = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAddStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchGenre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gridBookIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalLibraryDataSet = new PersonalLibrary.PersonalLibraryDataSet();
            this.booksTableAdapter = new PersonalLibrary.PersonalLibraryDataSetTableAdapters.BooksTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAddEntry.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddEntry
            // 
            this.grpAddEntry.Controls.Add(this.btnAdd);
            this.grpAddEntry.Controls.Add(this.cmbAddStatus);
            this.grpAddEntry.Controls.Add(this.label5);
            this.grpAddEntry.Controls.Add(this.txtAddGenre);
            this.grpAddEntry.Controls.Add(this.label4);
            this.grpAddEntry.Controls.Add(this.txtAddYear);
            this.grpAddEntry.Controls.Add(this.label3);
            this.grpAddEntry.Controls.Add(this.txtAddAuthor);
            this.grpAddEntry.Controls.Add(this.label2);
            this.grpAddEntry.Controls.Add(this.txtAddTitle);
            this.grpAddEntry.Controls.Add(this.label1);
            this.grpAddEntry.Location = new System.Drawing.Point(37, 65);
            this.grpAddEntry.Name = "grpAddEntry";
            this.grpAddEntry.Size = new System.Drawing.Size(634, 143);
            this.grpAddEntry.TabIndex = 0;
            this.grpAddEntry.TabStop = false;
            this.grpAddEntry.Text = "Add Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(42, 28);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(329, 20);
            this.txtAddTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(454, 28);
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(164, 20);
            this.txtAddAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(42, 69);
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(118, 20);
            this.txtAddYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre:";
            // 
            // txtAddGenre
            // 
            this.txtAddGenre.Location = new System.Drawing.Point(253, 69);
            this.txtAddGenre.Name = "txtAddGenre";
            this.txtAddGenre.Size = new System.Drawing.Size(118, 20);
            this.txtAddGenre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status:";
            // 
            // cmbAddStatus
            // 
            this.cmbAddStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Available",
            "Checked Out"});
            this.cmbAddStatus.FormattingEnabled = true;
            this.cmbAddStatus.Items.AddRange(new object[] {
            "Available",
            "Checked Out"});
            this.cmbAddStatus.Location = new System.Drawing.Point(454, 69);
            this.cmbAddStatus.Name = "cmbAddStatus";
            this.cmbAddStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbAddStatus.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(284, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Entry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.cmbSearchStatus);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.txtSearchGenre);
            this.grpSearch.Controls.Add(this.label7);
            this.grpSearch.Controls.Add(this.txtSearchYear);
            this.grpSearch.Controls.Add(this.label8);
            this.grpSearch.Controls.Add(this.txtSearchAuthor);
            this.grpSearch.Controls.Add(this.label9);
            this.grpSearch.Controls.Add(this.txtSearchTitle);
            this.grpSearch.Controls.Add(this.label10);
            this.grpSearch.Location = new System.Drawing.Point(37, 225);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(634, 143);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(284, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchStatus
            // 
            this.cmbSearchStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Available",
            "Checked Out"});
            this.cmbSearchStatus.FormattingEnabled = true;
            this.cmbSearchStatus.Items.AddRange(new object[] {
            "Available",
            "Checked Out"});
            this.cmbSearchStatus.Location = new System.Drawing.Point(454, 69);
            this.cmbSearchStatus.Name = "cmbSearchStatus";
            this.cmbSearchStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchStatus.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Status:";
            // 
            // txtSearchGenre
            // 
            this.txtSearchGenre.Location = new System.Drawing.Point(253, 69);
            this.txtSearchGenre.Name = "txtSearchGenre";
            this.txtSearchGenre.Size = new System.Drawing.Size(118, 20);
            this.txtSearchGenre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genre:";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(42, 69);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(118, 20);
            this.txtSearchYear.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Year:";
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(454, 28);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.Size = new System.Drawing.Size(164, 20);
            this.txtSearchAuthor.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Author:";
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(42, 28);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(329, 20);
            this.txtSearchTitle.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Title:";
            // 
            // gridBooks
            // 
            this.gridBooks.AutoGenerateColumns = false;
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridBookIDColumn,
            this.gridTitleColumn,
            this.gridAuthorColumn,
            this.gridGenreColumn,
            this.gridYearColumn,
            this.gridStatusColumn,
            this.UpdateColumn,
            this.DeleteColumn});
            this.gridBooks.DataSource = this.booksBindingSource;
            this.gridBooks.Location = new System.Drawing.Point(37, 429);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.Size = new System.Drawing.Size(745, 150);
            this.gridBooks.TabIndex = 12;
            this.gridBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBooks_CellContentClick);
            this.gridBooks.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBooks_CellLeave);
            this.gridBooks.Leave += new System.EventHandler(this.gridBooks_Leave);
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "";
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.Text = "Update";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // gridBookIDColumn
            // 
            this.gridBookIDColumn.DataPropertyName = "BookID";
            this.gridBookIDColumn.HeaderText = "BookID";
            this.gridBookIDColumn.Name = "gridBookIDColumn";
            this.gridBookIDColumn.ReadOnly = true;
            this.gridBookIDColumn.Visible = false;
            // 
            // gridTitleColumn
            // 
            this.gridTitleColumn.DataPropertyName = "Title";
            this.gridTitleColumn.HeaderText = "Title";
            this.gridTitleColumn.Name = "gridTitleColumn";
            // 
            // gridAuthorColumn
            // 
            this.gridAuthorColumn.DataPropertyName = "Author";
            this.gridAuthorColumn.HeaderText = "Author";
            this.gridAuthorColumn.Name = "gridAuthorColumn";
            // 
            // gridGenreColumn
            // 
            this.gridGenreColumn.DataPropertyName = "Genre";
            this.gridGenreColumn.HeaderText = "Genre";
            this.gridGenreColumn.Name = "gridGenreColumn";
            // 
            // gridYearColumn
            // 
            this.gridYearColumn.DataPropertyName = "Year";
            this.gridYearColumn.HeaderText = "Year";
            this.gridYearColumn.Name = "gridYearColumn";
            // 
            // gridStatusColumn
            // 
            this.gridStatusColumn.DataPropertyName = "Status";
            this.gridStatusColumn.HeaderText = "Status";
            this.gridStatusColumn.Items.AddRange(new object[] {
            "Available",
            "Checked Out"});
            this.gridStatusColumn.Name = "gridStatusColumn";
            this.gridStatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.personalLibraryDataSet;
            // 
            // personalLibraryDataSet
            // 
            this.personalLibraryDataSet.DataSetName = "PersonalLibraryDataSet";
            this.personalLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(37, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridBooks);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpAddEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddEntry.ResumeLayout(false);
            this.grpAddEntry.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLibraryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAddStatus;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridBooks;
        private PersonalLibraryDataSet personalLibraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private PersonalLibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBookIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridGenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridYearColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gridStatusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Button button1;
    }
}


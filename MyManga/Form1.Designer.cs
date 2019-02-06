namespace MyManga
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
            this.addBtn = new System.Windows.Forms.Button();
            this.mangaDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangatype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaCover = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.colCB = new System.Windows.Forms.ComboBox();
            this.totalOfMangaLable = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.aMangaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mangaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(58, 182);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Manga";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // mangaDGV
            // 
            this.mangaDGV.AllowUserToAddRows = false;
            this.mangaDGV.AllowUserToDeleteRows = false;
            this.mangaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mangaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mangaName,
            this.mangaAuthor,
            this.mangaGenre,
            this.mangatype,
            this.mangaCover});
            this.mangaDGV.Location = new System.Drawing.Point(12, 26);
            this.mangaDGV.Name = "mangaDGV";
            this.mangaDGV.ReadOnly = true;
            this.mangaDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mangaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mangaDGV.Size = new System.Drawing.Size(629, 150);
            this.mangaDGV.TabIndex = 2;
            this.mangaDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mangaDGV_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // mangaName
            // 
            this.mangaName.HeaderText = "MangaName";
            this.mangaName.Name = "mangaName";
            this.mangaName.ReadOnly = true;
            this.mangaName.Width = 93;
            // 
            // mangaAuthor
            // 
            this.mangaAuthor.HeaderText = "Author";
            this.mangaAuthor.Name = "mangaAuthor";
            this.mangaAuthor.ReadOnly = true;
            this.mangaAuthor.Width = 63;
            // 
            // mangaGenre
            // 
            this.mangaGenre.HeaderText = "Genre";
            this.mangaGenre.Name = "mangaGenre";
            this.mangaGenre.ReadOnly = true;
            this.mangaGenre.Width = 61;
            // 
            // mangatype
            // 
            this.mangatype.HeaderText = "Type";
            this.mangatype.Name = "mangatype";
            this.mangatype.ReadOnly = true;
            this.mangatype.Width = 56;
            // 
            // mangaCover
            // 
            this.mangaCover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mangaCover.HeaderText = "Cover";
            this.mangaCover.Name = "mangaCover";
            this.mangaCover.ReadOnly = true;
            this.mangaCover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(427, 182);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(162, 182);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 20);
            this.searchTB.TabIndex = 4;
            this.searchTB.Text = "Search";
            // 
            // colCB
            // 
            this.colCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colCB.FormattingEnabled = true;
            this.colCB.Items.AddRange(new object[] {
            "Name",
            "Author",
            "Genre"});
            this.colCB.Location = new System.Drawing.Point(269, 182);
            this.colCB.Name = "colCB";
            this.colCB.Size = new System.Drawing.Size(121, 21);
            this.colCB.TabIndex = 5;
            // 
            // totalOfMangaLable
            // 
            this.totalOfMangaLable.AutoSize = true;
            this.totalOfMangaLable.Location = new System.Drawing.Point(179, 7);
            this.totalOfMangaLable.Name = "totalOfMangaLable";
            this.totalOfMangaLable.Size = new System.Drawing.Size(78, 13);
            this.totalOfMangaLable.TabIndex = 6;
            this.totalOfMangaLable.Text = "Total of manga";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(269, 7);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(63, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Placeholder";
            // 
            // aMangaBtn
            // 
            this.aMangaBtn.Location = new System.Drawing.Point(525, 182);
            this.aMangaBtn.Name = "aMangaBtn";
            this.aMangaBtn.Size = new System.Drawing.Size(75, 23);
            this.aMangaBtn.TabIndex = 8;
            this.aMangaBtn.Text = "All Manga";
            this.aMangaBtn.UseVisualStyleBackColor = true;
            this.aMangaBtn.Click += new System.EventHandler(this.aMangaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 234);
            this.Controls.Add(this.aMangaBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalOfMangaLable);
            this.Controls.Add(this.colCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.mangaDGV);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mangaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        internal System.Windows.Forms.DataGridView mangaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangatype;
        private System.Windows.Forms.DataGridViewImageColumn mangaCover;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTB;
        internal System.Windows.Forms.ComboBox colCB;
        private System.Windows.Forms.Label totalOfMangaLable;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button aMangaBtn;
    }
}


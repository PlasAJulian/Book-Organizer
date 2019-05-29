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
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.colCB = new System.Windows.Forms.ComboBox();
            this.totalOfMangaLable = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.aMangaBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangatype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangaCover = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mangaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addBtn.Location = new System.Drawing.Point(16, 229);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 28);
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
            this.mangaDGV.BackgroundColor = System.Drawing.Color.White;
            this.mangaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mangaName,
            this.mangaAuthor,
            this.mangaGenre,
            this.mangatype,
            this.mangaCover});
            this.mangaDGV.GridColor = System.Drawing.Color.SlateBlue;
            this.mangaDGV.Location = new System.Drawing.Point(16, 32);
            this.mangaDGV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mangaDGV.Name = "mangaDGV";
            this.mangaDGV.ReadOnly = true;
            this.mangaDGV.RowHeadersVisible = false;
            this.mangaDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mangaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mangaDGV.Size = new System.Drawing.Size(839, 183);
            this.mangaDGV.TabIndex = 2;
            this.mangaDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mangaDGV_CellContentDoubleClick);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchBtn.Location = new System.Drawing.Point(754, 229);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 28);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(428, 234);
            this.searchTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(132, 23);
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
            this.colCB.Location = new System.Drawing.Point(570, 233);
            this.colCB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.colCB.Name = "colCB";
            this.colCB.Size = new System.Drawing.Size(159, 24);
            this.colCB.TabIndex = 5;
            // 
            // totalOfMangaLable
            // 
            this.totalOfMangaLable.AutoSize = true;
            this.totalOfMangaLable.ForeColor = System.Drawing.Color.White;
            this.totalOfMangaLable.Location = new System.Drawing.Point(239, 9);
            this.totalOfMangaLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalOfMangaLable.Name = "totalOfMangaLable";
            this.totalOfMangaLable.Size = new System.Drawing.Size(108, 16);
            this.totalOfMangaLable.TabIndex = 6;
            this.totalOfMangaLable.Text = "Total of manga";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(359, 9);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(83, 16);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Placeholder";
            // 
            // aMangaBtn
            // 
            this.aMangaBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aMangaBtn.Location = new System.Drawing.Point(136, 230);
            this.aMangaBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.aMangaBtn.Name = "aMangaBtn";
            this.aMangaBtn.Size = new System.Drawing.Size(101, 28);
            this.aMangaBtn.TabIndex = 8;
            this.aMangaBtn.Text = "All Manga";
            this.aMangaBtn.UseVisualStyleBackColor = true;
            this.aMangaBtn.Click += new System.EventHandler(this.aMangaBtn_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 47;
            // 
            // mangaName
            // 
            this.mangaName.HeaderText = "MangaName";
            this.mangaName.Name = "mangaName";
            this.mangaName.ReadOnly = true;
            this.mangaName.Width = 112;
            // 
            // mangaAuthor
            // 
            this.mangaAuthor.HeaderText = "Author";
            this.mangaAuthor.Name = "mangaAuthor";
            this.mangaAuthor.ReadOnly = true;
            this.mangaAuthor.Width = 77;
            // 
            // mangaGenre
            // 
            this.mangaGenre.HeaderText = "Genre";
            this.mangaGenre.Name = "mangaGenre";
            this.mangaGenre.ReadOnly = true;
            this.mangaGenre.Width = 71;
            // 
            // mangatype
            // 
            this.mangatype.HeaderText = "Type";
            this.mangatype.Name = "mangatype";
            this.mangatype.ReadOnly = true;
            this.mangatype.Width = 66;
            // 
            // mangaCover
            // 
            this.mangaCover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mangaCover.HeaderText = "Cover";
            this.mangaCover.Name = "mangaCover";
            this.mangaCover.ReadOnly = true;
            this.mangaCover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(871, 288);
            this.Controls.Add(this.aMangaBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalOfMangaLable);
            this.Controls.Add(this.colCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.mangaDGV);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Moccasin;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mangaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        internal System.Windows.Forms.DataGridView mangaDGV;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label totalOfMangaLable;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button aMangaBtn;
        public System.Windows.Forms.ComboBox colCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangaGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangatype;
        private System.Windows.Forms.DataGridViewImageColumn mangaCover;
    }
}


namespace MyManga
{
    partial class Add_Manga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Manga));
            this.mNameLabel = new System.Windows.Forms.Label();
            this.mAuthorLabel = new System.Windows.Forms.Label();
            this.mGenresLabel = new System.Windows.Forms.Label();
            this.dOrPLabel = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.mNameTB = new System.Windows.Forms.TextBox();
            this.mAuthorTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.newMangaPB = new System.Windows.Forms.PictureBox();
            this.mangaGenresCLB = new System.Windows.Forms.CheckedListBox();
            this.mangaCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newMangaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mNameLabel
            // 
            this.mNameLabel.AutoSize = true;
            this.mNameLabel.Location = new System.Drawing.Point(12, 16);
            this.mNameLabel.Name = "mNameLabel";
            this.mNameLabel.Size = new System.Drawing.Size(74, 13);
            this.mNameLabel.TabIndex = 0;
            this.mNameLabel.Text = "Manga Name:";
            // 
            // mAuthorLabel
            // 
            this.mAuthorLabel.AutoSize = true;
            this.mAuthorLabel.Location = new System.Drawing.Point(210, 16);
            this.mAuthorLabel.Name = "mAuthorLabel";
            this.mAuthorLabel.Size = new System.Drawing.Size(77, 13);
            this.mAuthorLabel.TabIndex = 1;
            this.mAuthorLabel.Text = "Manga Author:";
            // 
            // mGenresLabel
            // 
            this.mGenresLabel.AutoSize = true;
            this.mGenresLabel.Location = new System.Drawing.Point(9, 130);
            this.mGenresLabel.Name = "mGenresLabel";
            this.mGenresLabel.Size = new System.Drawing.Size(77, 13);
            this.mGenresLabel.TabIndex = 2;
            this.mGenresLabel.Text = "Manga Genres";
            // 
            // dOrPLabel
            // 
            this.dOrPLabel.AutoSize = true;
            this.dOrPLabel.Location = new System.Drawing.Point(12, 73);
            this.dOrPLabel.Name = "dOrPLabel";
            this.dOrPLabel.Size = new System.Drawing.Size(93, 13);
            this.dOrPLabel.TabIndex = 3;
            this.dOrPLabel.Text = "Digital or Physical:";
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Digital",
            "Physical"});
            this.typeCB.Location = new System.Drawing.Point(111, 73);
            this.typeCB.MaxDropDownItems = 2;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(78, 21);
            this.typeCB.TabIndex = 4;
            // 
            // mNameTB
            // 
            this.mNameTB.Location = new System.Drawing.Point(89, 16);
            this.mNameTB.Name = "mNameTB";
            this.mNameTB.Size = new System.Drawing.Size(100, 20);
            this.mNameTB.TabIndex = 5;
            // 
            // mAuthorTB
            // 
            this.mAuthorTB.Location = new System.Drawing.Point(290, 16);
            this.mAuthorTB.Name = "mAuthorTB";
            this.mAuthorTB.Size = new System.Drawing.Size(100, 20);
            this.mAuthorTB.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(142, 309);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 28);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Manga";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // newMangaPB
            // 
            this.newMangaPB.Image = ((System.Drawing.Image)(resources.GetObject("newMangaPB.Image")));
            this.newMangaPB.Location = new System.Drawing.Point(299, 43);
            this.newMangaPB.Name = "newMangaPB";
            this.newMangaPB.Size = new System.Drawing.Size(91, 100);
            this.newMangaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newMangaPB.TabIndex = 9;
            this.newMangaPB.TabStop = false;
            this.newMangaPB.Click += new System.EventHandler(this.newMangaPB_Click);
            // 
            // mangaGenresCLB
            // 
            this.mangaGenresCLB.FormattingEnabled = true;
            this.mangaGenresCLB.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Cyberpunk",
            "Demons",
            "Drama",
            "Ecchi",
            "Fantasy",
            "Game",
            "Harem",
            "Hentai",
            "Historical",
            "Horror",
            "Isekai",
            "Josei",
            "Kids",
            "Magic",
            "Martial Arts",
            "Mecha",
            "Military",
            "Music",
            "Mystery",
            "Parody",
            "Police",
            "Post-Apocalyptic",
            "Psychological",
            "Reverse Harem",
            "Romance",
            "School",
            "Sci-Fi",
            "Seinen",
            "Shoujo",
            "Shoujo-ai",
            "Shounen",
            "Slice of Life",
            "Space",
            "Sports",
            "Super Power",
            "Supernatural",
            "Tragedy",
            "Vampire",
            "Yaoi",
            "Yuri"});
            this.mangaGenresCLB.Location = new System.Drawing.Point(12, 149);
            this.mangaGenresCLB.MultiColumn = true;
            this.mangaGenresCLB.Name = "mangaGenresCLB";
            this.mangaGenresCLB.Size = new System.Drawing.Size(378, 154);
            this.mangaGenresCLB.TabIndex = 10;
            // 
            // mangaCLabel
            // 
            this.mangaCLabel.AutoSize = true;
            this.mangaCLabel.Location = new System.Drawing.Point(219, 76);
            this.mangaCLabel.Name = "mangaCLabel";
            this.mangaCLabel.Size = new System.Drawing.Size(74, 13);
            this.mangaCLabel.TabIndex = 11;
            this.mangaCLabel.Text = "Manga Cover:";
            // 
            // Add_Manga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 346);
            this.Controls.Add(this.mangaCLabel);
            this.Controls.Add(this.mangaGenresCLB);
            this.Controls.Add(this.newMangaPB);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.mAuthorTB);
            this.Controls.Add(this.mNameTB);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.dOrPLabel);
            this.Controls.Add(this.mGenresLabel);
            this.Controls.Add(this.mAuthorLabel);
            this.Controls.Add(this.mNameLabel);
            this.Name = "Add_Manga";
            this.Text = "Add_Manga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Manga_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.newMangaPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mNameLabel;
        private System.Windows.Forms.Label mAuthorLabel;
        private System.Windows.Forms.Label mGenresLabel;
        private System.Windows.Forms.Label dOrPLabel;
        private System.Windows.Forms.TextBox mNameTB;
        private System.Windows.Forms.TextBox mAuthorTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.PictureBox newMangaPB;
        private System.Windows.Forms.CheckedListBox mangaGenresCLB;
        private System.Windows.Forms.Label mangaCLabel;
    }
}
namespace MyManga
{
    partial class MangaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangaInfo));
            this.mNameLabel = new System.Windows.Forms.Label();
            this.mAuthorLabel = new System.Windows.Forms.Label();
            this.mGenresLabel = new System.Windows.Forms.Label();
            this.mNameTB = new System.Windows.Forms.TextBox();
            this.mAuthorTB = new System.Windows.Forms.TextBox();
            this.newMangaPB = new System.Windows.Forms.PictureBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.mIDLlabel = new System.Windows.Forms.Label();
            this.idL = new System.Windows.Forms.Label();
            this.mangaGenresCLB = new System.Windows.Forms.CheckedListBox();
            this.mangaCLabel = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.dOrPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newMangaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // mNameLabel
            // 
            this.mNameLabel.AutoSize = true;
            this.mNameLabel.Location = new System.Drawing.Point(28, 36);
            this.mNameLabel.Name = "mNameLabel";
            this.mNameLabel.Size = new System.Drawing.Size(74, 13);
            this.mNameLabel.TabIndex = 0;
            this.mNameLabel.Text = "Manga Name:";
            // 
            // mAuthorLabel
            // 
            this.mAuthorLabel.AutoSize = true;
            this.mAuthorLabel.Location = new System.Drawing.Point(25, 70);
            this.mAuthorLabel.Name = "mAuthorLabel";
            this.mAuthorLabel.Size = new System.Drawing.Size(77, 13);
            this.mAuthorLabel.TabIndex = 1;
            this.mAuthorLabel.Text = "Manga Author:";
            // 
            // mGenresLabel
            // 
            this.mGenresLabel.AutoSize = true;
            this.mGenresLabel.Location = new System.Drawing.Point(26, 135);
            this.mGenresLabel.Name = "mGenresLabel";
            this.mGenresLabel.Size = new System.Drawing.Size(77, 13);
            this.mGenresLabel.TabIndex = 2;
            this.mGenresLabel.Text = "Manga Genres";
            // 
            // mNameTB
            // 
            this.mNameTB.Location = new System.Drawing.Point(105, 33);
            this.mNameTB.Name = "mNameTB";
            this.mNameTB.Size = new System.Drawing.Size(100, 20);
            this.mNameTB.TabIndex = 4;
            // 
            // mAuthorTB
            // 
            this.mAuthorTB.Location = new System.Drawing.Point(105, 63);
            this.mAuthorTB.Name = "mAuthorTB";
            this.mAuthorTB.Size = new System.Drawing.Size(100, 20);
            this.mAuthorTB.TabIndex = 5;
            // 
            // newMangaPB
            // 
            this.newMangaPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMangaPB.Image = ((System.Drawing.Image)(resources.GetObject("newMangaPB.Image")));
            this.newMangaPB.Location = new System.Drawing.Point(298, 24);
            this.newMangaPB.Name = "newMangaPB";
            this.newMangaPB.Size = new System.Drawing.Size(109, 124);
            this.newMangaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newMangaPB.TabIndex = 8;
            this.newMangaPB.TabStop = false;
            this.newMangaPB.Click += new System.EventHandler(this.CoverPictureBox_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(174, 320);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 9;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // mIDLlabel
            // 
            this.mIDLlabel.AutoSize = true;
            this.mIDLlabel.Location = new System.Drawing.Point(64, 9);
            this.mIDLlabel.Name = "mIDLlabel";
            this.mIDLlabel.Size = new System.Drawing.Size(21, 13);
            this.mIDLlabel.TabIndex = 10;
            this.mIDLlabel.Text = "ID:";
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Location = new System.Drawing.Point(102, 9);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(63, 13);
            this.idL.TabIndex = 11;
            this.idL.Text = "Placeholder";
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
            this.mangaGenresCLB.Location = new System.Drawing.Point(29, 154);
            this.mangaGenresCLB.MultiColumn = true;
            this.mangaGenresCLB.Name = "mangaGenresCLB";
            this.mangaGenresCLB.Size = new System.Drawing.Size(378, 154);
            this.mangaGenresCLB.TabIndex = 12;
            // 
            // mangaCLabel
            // 
            this.mangaCLabel.AutoSize = true;
            this.mangaCLabel.Location = new System.Drawing.Point(221, 33);
            this.mangaCLabel.Name = "mangaCLabel";
            this.mangaCLabel.Size = new System.Drawing.Size(74, 13);
            this.mangaCLabel.TabIndex = 13;
            this.mangaCLabel.Text = "Manga Cover:";
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Digital",
            "Physical"});
            this.typeCB.Location = new System.Drawing.Point(154, 109);
            this.typeCB.MaxDropDownItems = 2;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(78, 21);
            this.typeCB.TabIndex = 15;
            // 
            // dOrPLabel
            // 
            this.dOrPLabel.AutoSize = true;
            this.dOrPLabel.Location = new System.Drawing.Point(61, 109);
            this.dOrPLabel.Name = "dOrPLabel";
            this.dOrPLabel.Size = new System.Drawing.Size(93, 13);
            this.dOrPLabel.TabIndex = 14;
            this.dOrPLabel.Text = "Digital or Physical:";
            // 
            // MangaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 346);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.dOrPLabel);
            this.Controls.Add(this.mangaCLabel);
            this.Controls.Add(this.mangaGenresCLB);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.mIDLlabel);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.newMangaPB);
            this.Controls.Add(this.mAuthorTB);
            this.Controls.Add(this.mNameTB);
            this.Controls.Add(this.mGenresLabel);
            this.Controls.Add(this.mAuthorLabel);
            this.Controls.Add(this.mNameLabel);
            this.Name = "MangaInfo";
            this.Text = "MangaInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MangaInfo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.newMangaPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mNameLabel;
        private System.Windows.Forms.Label mAuthorLabel;
        private System.Windows.Forms.Label mGenresLabel;
        internal System.Windows.Forms.TextBox mNameTB;
        internal System.Windows.Forms.TextBox mAuthorTB;
        internal System.Windows.Forms.PictureBox newMangaPB;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Label mIDLlabel;
        internal System.Windows.Forms.Label idL;
        private System.Windows.Forms.CheckedListBox mangaGenresCLB;
        private System.Windows.Forms.Label mangaCLabel;
        private System.Windows.Forms.Label dOrPLabel;
        internal System.Windows.Forms.ComboBox typeCB;
    }
}
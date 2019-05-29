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
            this.mNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mNameLabel.Location = new System.Drawing.Point(16, 20);
            this.mNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mNameLabel.Name = "mNameLabel";
            this.mNameLabel.Size = new System.Drawing.Size(93, 16);
            this.mNameLabel.TabIndex = 0;
            this.mNameLabel.Text = "Manga Name:";
            // 
            // mAuthorLabel
            // 
            this.mAuthorLabel.AutoSize = true;
            this.mAuthorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mAuthorLabel.Location = new System.Drawing.Point(280, 20);
            this.mAuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mAuthorLabel.Name = "mAuthorLabel";
            this.mAuthorLabel.Size = new System.Drawing.Size(94, 16);
            this.mAuthorLabel.TabIndex = 1;
            this.mAuthorLabel.Text = "Manga Author:";
            // 
            // mGenresLabel
            // 
            this.mGenresLabel.AutoSize = true;
            this.mGenresLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mGenresLabel.Location = new System.Drawing.Point(12, 160);
            this.mGenresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mGenresLabel.Name = "mGenresLabel";
            this.mGenresLabel.Size = new System.Drawing.Size(97, 16);
            this.mGenresLabel.TabIndex = 2;
            this.mGenresLabel.Text = "Manga Genres";
            // 
            // dOrPLabel
            // 
            this.dOrPLabel.AutoSize = true;
            this.dOrPLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dOrPLabel.Location = new System.Drawing.Point(16, 90);
            this.dOrPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dOrPLabel.Name = "dOrPLabel";
            this.dOrPLabel.Size = new System.Drawing.Size(118, 16);
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
            this.typeCB.Location = new System.Drawing.Point(148, 90);
            this.typeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeCB.MaxDropDownItems = 2;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(103, 24);
            this.typeCB.TabIndex = 4;
            // 
            // mNameTB
            // 
            this.mNameTB.Location = new System.Drawing.Point(119, 20);
            this.mNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mNameTB.Name = "mNameTB";
            this.mNameTB.Size = new System.Drawing.Size(132, 22);
            this.mNameTB.TabIndex = 5;
            // 
            // mAuthorTB
            // 
            this.mAuthorTB.Location = new System.Drawing.Point(387, 20);
            this.mAuthorTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAuthorTB.Name = "mAuthorTB";
            this.mAuthorTB.Size = new System.Drawing.Size(132, 22);
            this.mAuthorTB.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(189, 380);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 34);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Manga";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // newMangaPB
            // 
            this.newMangaPB.Image = ((System.Drawing.Image)(resources.GetObject("newMangaPB.Image")));
            this.newMangaPB.Location = new System.Drawing.Point(399, 53);
            this.newMangaPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newMangaPB.Name = "newMangaPB";
            this.newMangaPB.Size = new System.Drawing.Size(121, 123);
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
            this.mangaGenresCLB.Location = new System.Drawing.Point(16, 183);
            this.mangaGenresCLB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mangaGenresCLB.MultiColumn = true;
            this.mangaGenresCLB.Name = "mangaGenresCLB";
            this.mangaGenresCLB.Size = new System.Drawing.Size(503, 174);
            this.mangaGenresCLB.TabIndex = 10;
            // 
            // mangaCLabel
            // 
            this.mangaCLabel.AutoSize = true;
            this.mangaCLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mangaCLabel.Location = new System.Drawing.Point(292, 94);
            this.mangaCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mangaCLabel.Name = "mangaCLabel";
            this.mangaCLabel.Size = new System.Drawing.Size(92, 16);
            this.mangaCLabel.TabIndex = 11;
            this.mangaCLabel.Text = "Manga Cover:";
            // 
            // Add_Manga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(559, 426);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Add_Manga";
            this.ShowIcon = false;
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
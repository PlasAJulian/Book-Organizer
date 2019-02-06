/*************************
 * 	    Julian A P.	     *
 *	   Manga project     *
 * C# and .NET Framework *
 *      using MVS        *
 ************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyManga
{
    public partial class Form1 : Form
    {
        //variables used
        manga load = new manga();
        Image img;
        public Form1()
        {
            InitializeComponent();
        }
        //executes fillTable method when Form1 is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            load.getAllManga();
            totalLabel.Text = load.arrL.count.ToString();
            fillTable(load.arrL.arrlist);   
        }
        //fills table
        public void fillTable(ArrayList list)
        {
            //runs getAllManage in object to get all manga in database
            //test.arrL.display();
            //addes everything in mangaList array to datagirdview
            foreach (manga a in list)
            {
                //checks if the cover of the manga exists, if not uses default picture
                if (File.Exists(a.mangaCover))
                {
                    img = Image.FromFile(a.mangaCover);
                }
                else
                {
                    img = Image.FromFile("C:/Users/GhostBit/source/repos/MyManga/MyManga/Covers/default.jpg");//change
                }
                Object[] row = new Object[] { a.idNum, a.mangaName, a.mangaAuthor, a.mangaGenre, a.mangaType, img };
                mangaDGV.Rows.Add(row);
            }
        }
        //opens form to add a new manga to database and datagirdview
        private void addBtn_Click(object sender, EventArgs e)
        {
            Form addForm = new Add_Manga(this);
            addForm.Show();
            Enabled = false;
        }
        //when cell is double clicked opens new form to allow user to edit information.
        private void mangaDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //passes all variables to MangaInfo form where data can be updated if needed.
            MangaInfo info = new MangaInfo(this);
            info.idL.Text = this.mangaDGV.CurrentRow.Cells[0].Value.ToString();
            info.mNameTB.Text = this.mangaDGV.CurrentRow.Cells[1].Value.ToString();
            info.mAuthorTB.Text = this.mangaDGV.CurrentRow.Cells[2].Value.ToString();
            info.spitGenres(this.mangaDGV.CurrentRow.Cells[3].Value.ToString());
            info.typeCB.Text = this.mangaDGV.CurrentRow.Cells[4].Value.ToString();
            Bitmap img = (Bitmap)mangaDGV.CurrentRow.Cells[5].Value;
            info.getCoverBit(img);
            info.Show();
            Enabled = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //gets both string from the form and trims the extra spaces from the front and end of the keyword.
            string key = searchTB.Text;
            string c = colCB.Text;
            key = key.Trim(' ');
            //makes sure nothing is null or empty
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(c))
            {
                MessageBox.Show("Some Information is missing.");
            }
            else
            {
                manga s = new manga();
                s.search(key, c);
                //if there is no search result, shows message.
                if (s.arrL.count == 0)
                {
                    MessageBox.Show("Sorry there is no manga for " + key + " under " + c);
                }
                //when manga is found clears the datagridview and displays the search result.
                else
                {
                    mangaDGV.Rows.Clear();
                    totalLabel.Text = s.arrL.count.ToString();
                    fillTable(s.arrL.arrlist);
                }
            }
        }

        private void aMangaBtn_Click(object sender, EventArgs e)
        {
            mangaDGV.Rows.Clear();
            totalLabel.Text = load.arrL.count.ToString();
            fillTable(load.arrL.arrlist);
        }
    }
}

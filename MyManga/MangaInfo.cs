/*************************
 * 	    Julian A P.	     *
 *	   Manga project     *
 * C# and .NET Framework *
 *      using MVS        *
 *      
 ************************/
using System;
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
    public partial class MangaInfo : Form
    {
        //variables
        int id;
        string name;
        string author;
        string genres;
        string type;
        string cover;
        manga up = new manga();
        Form1 frm1;
        public MangaInfo()
        {
            InitializeComponent();
        }
        //pulls Form1 to update datagirdview when manga is added.
        public MangaInfo(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        //gets data from form and updates manga in database and updates datagridview
        private void updateBTN_Click(object sender, EventArgs e)
        {
            getinfoUpdate();
        }
        //get info from form to update database
        public void getinfoUpdate()
        {
            id = Int32.Parse(idL.Text);
            name = mNameTB.Text;
            author = mAuthorTB.Text;
            getGenres();
            up.selectSingleManga(id);
            type = typeCB.Text;
            //error message if some information is missing.
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(genres) || string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Some information is missing");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(cover))
                {
                    cover = up.mangaCover;
                }
                //Double checks with user, id all information is right.
                DialogResult ans = MessageBox.Show("Is this information right?\n Name:" + name +
                    "\n Author: " + author +
                    "\n Genres: " + genres +
                    "\n Type: " + type +
                    "\n File Loaction: " + cover,
                    "Check", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                    {
                        up.mangaName = name;
                        up.mangaAuthor = author;
                        up.mangaGenre = genres;
                        up.mangaType = type;
                        up.mangaCover = cover;
                        up.updateSingleManga();
                        //Executes update query 
                        updateDataGridView();
                        frm1.Enabled = true;
                        MessageBox.Show("Data has been updated.");
                        Close();
                    }
                else if (ans == DialogResult.No)
                {
                    genres = null;
                }
            }
        }
        //converts bitmap to image and fills picturebox
        public void getCoverBit(Bitmap i)
        {
            MemoryStream ms = new MemoryStream();
            i.Save(ms, ImageFormat.Jpeg);
            newMangaPB.Image = Image.FromStream(ms);
        }
        //opens file dialog when picturebox is clicked to select cover for manga
        private void CoverPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imgae File(*.jpg)|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                newMangaPB.Image = new Bitmap(ofd.FileName);
                cover = ofd.FileName;
            }
        }
        //spits genre string from database to checks box in checkboxlist
        public void spitGenres(string sent)
        {
            string[] namesArray = sent.Split(',');
            List<string> namesList = new List<string>(namesArray.Length);
            namesList.AddRange(namesArray);
            foreach (string word in namesList)
            {
                int index = mangaGenresCLB.Items.IndexOf(word);

                if (index >= 0)
                {
                    mangaGenresCLB.SetItemChecked(index, true);
                }
                //Console.WriteLine(word);
            }
        }
        //gets genre from checkboxlist that were selected and makes them into a single string.
        public void getGenres()
        {
            if (mangaGenresCLB.CheckedItems.Count != 0)
            {
                for (int x = 0; x < mangaGenresCLB.CheckedItems.Count; x++)
                {
                    genres = genres + mangaGenresCLB.CheckedItems[x].ToString() + ",";
                }
                genres = genres.TrimEnd(',');
            }
        }
        //updates data grid view from Form1
        public void updateDataGridView()
        {
            frm1.mangaDGV.CurrentRow.Cells[0].Value = id;
            frm1.mangaDGV.CurrentRow.Cells[1].Value = name;
            frm1.mangaDGV.CurrentRow.Cells[2].Value = author;
            frm1.mangaDGV.CurrentRow.Cells[3].Value = genres;
            frm1.mangaDGV.CurrentRow.Cells[4].Value = type;
            frm1.mangaDGV.CurrentRow.Cells[5].Value = newMangaPB.Image;
        }
        //when form is closed lets user enable access to Form1
        private void MangaInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Enabled = true;
        }
    }
}

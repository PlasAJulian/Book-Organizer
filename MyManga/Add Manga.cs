/*************************
 * 	    Julian A P.	     *
 *	   Manga project     *
 * C# and .NET Framework *
 *      using MVS        *
 ************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyManga
{
    public partial class Add_Manga : Form
    {
        //variables used
        int id;
        string name;
        string author;
        string genres;
        string type;
        string file;
        private readonly Form1 frm1;
        public Add_Manga()
        {
            InitializeComponent();
        }
        //pulls Form1 to update datagirdview when manga is added.
        public Add_Manga(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        //add button runs getMangaInfo Method and adds row to datagirdview in form one 
        private void addBtn_Click(object sender, EventArgs e)
        {
            getNewMangaInfo();
        }
        //opens file dialog when picturebox is clicked to select a cover picture for manga.
        private void newMangaPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imgae File(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                newMangaPB.Image = new Bitmap(ofd.FileName);
                file = ofd.FileName;
                //Console.WriteLine(file);
            }
        }
        //get all genres checked from listbox and makes them into single string.
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
        //getNewMangaInfo method checks if all information is filled.
        public void getNewMangaInfo()
        {
            name = mNameTB.Text;
            author = mAuthorTB.Text;
            getGenres();
            type = typeCB.Text;
            //error message if some information is missing.
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(genres) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(file))
            {
                MessageBox.Show("Some information is missing");
                genres = null;
            }
            else
            {
                //Double checks with user, id all information is right.
                DialogResult ans = MessageBox.Show("Is this information right?\n Name:" + name +
                    "\n Author: " + author +
                    "\n Genres: " + genres +
                    "\n Type: " + type +
                    "\n File Loaction: " + file,
                    "Check", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    //execute insert query 
                    //////note- might make it to work with single manga object
                    manga getLast = new manga();
                    getLast.getLastAccount();
                    id = getLast.lastIDNum;
                    manga add = new manga(id, name, author, genres, type, file);
                    add.insertSingleManga();
                    Image img = Image.FromFile(file);
                    Object[] row = new Object[] { id, name, author, genres, type, img };
                    frm1.mangaDGV.Rows.Add(row);
                    MessageBox.Show("You added");
                    frm1.Enabled = true;
                    Close();
                }
                else if(ans == DialogResult.No)
                {
                    genres = null;
                }
            }
        }
        //when form is closed lets user enable access to Form1
        private void Add_Manga_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Enabled = true;
        }
    }
}

/*************************
 * 	    Julian A P.	     *
 *	   Manga project     *
 * C# and .NET Framework *
 *      using MVS        *
 ************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManga
{
    public class manga
    {
        // variables that will be used and filled with the database
        public int idNum { get; set; }
        public string mangaName { get; set; }
        public string mangaAuthor { get; set; }
        public string mangaGenre { get; set; }
        public string mangaType { get; set; }
        public string mangaCover { get; set; }
        public int lastIDNum { get; set; }
        // variables that run database
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection OleDbConnection2;
        public string cmd;
        public listOfManga arrL = new listOfManga();
        //default 
        public manga()
        {
            idNum = 0;
            mangaName = "";
            mangaAuthor = "";
            mangaGenre = "";
            mangaType = "";
            mangaCover = "";
        }
        //fill variables from method
        public manga(int id, string name, string author, string genre, string type, string mc)
        {
            idNum = id;
            mangaName = name;
            mangaAuthor = author;
            mangaGenre = genre;
            mangaType = type;
            mangaCover = mc;
        }
        //display Manga in Console. Used for testing.
        public void display()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("ID: " + idNum);
            Console.WriteLine("Name: " + mangaName);
            Console.WriteLine("Author Type: " + mangaAuthor);
            Console.WriteLine("Type: " + mangaType);
            Console.WriteLine("Genre: " + mangaGenre);
            Console.WriteLine("CoverFileName: " + mangaCover);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        //database setup connection
        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Reg" + "istry Path =; Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\GhostBit\\source\\repos\\MyManga\\MyManga\\database\\Mangas.mdb;J" +//change
            "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }
        //select query and fill variables with results
        public void selectSingleManga(int i)
        {
            DBSetup();
            //self note- change star to name of each coulma. incase new colams are added wont crash
            cmd = "Select * from Manga Where ID = " + i;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            //Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                //column numbers just in case columns are ever moved around
                int idColumn = dr.GetOrdinal("ID");
                int nameColumn = dr.GetOrdinal("Name");
                int authorColumn = dr.GetOrdinal("Author");
                int genreColumn = dr.GetOrdinal("Genre");
                int typeColumn = dr.GetOrdinal("DigitalorPhysical");
                int coverColumn = dr.GetOrdinal("CoverImg");
                //fills 
                idNum = (Int32.Parse(dr.GetValue(idColumn) + ""));
                mangaName = (dr.GetValue(nameColumn) + "");
                mangaAuthor = (dr.GetValue(authorColumn) + "");
                mangaGenre = (dr.GetValue(genreColumn) + "");
                mangaType = (dr.GetValue(typeColumn) + "");
                mangaCover = (dr.GetValue(coverColumn) + "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
        //gets last ID in data to be used when a new manga is added
        public void getLastAccount()
        {
            DBSetup();
            cmd = "SELECT ID FROM Manga Where ID = (SELECT MAX(ID) FROM Manga)";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            //Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                lastIDNum = Int32.Parse(dr.GetValue(0) + "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
            lastIDNum = lastIDNum + 1;
        }
        //insert query using fill variables from form/method
        public void insertSingleManga()
        {
            DBSetup();
            cmd = " INSERT INTO Manga " +
            "(ID, Name, Author, Genre, DigitalorPhysical, CoverImg) VALUES " +
            "(" + idNum + ", '" + mangaName+"', '"+mangaAuthor+"', '"+mangaGenre+"', '"+mangaType+"', '"+mangaCover+"');";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            //Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                    Console.WriteLine("Data added, I hope.");
                else
                    Console.WriteLine("ERROR: Inserting Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }

        }
        //update query, any changes made after the select query will be updated in the database .
        public void updateSingleManga()
        {
            cmd = "Update Manga set Name = '" + mangaName +
                           "', Author = '" + mangaAuthor +
                           "', Genre = '" + mangaGenre +
                           "', DigitalorPhysical = '" + mangaType +
                           "', CoverImg = '" + mangaCover +
                           "' Where ID = " + idNum + "";

            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            //Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                if (n == 1)
                    Console.WriteLine("Data Updated I hope");
                else
                    Console.WriteLine("ERROR: Updating Data");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
        //get id from all manga and added them to a list array.
        public void getAllManga()
        {
            DBSetup();
            cmd = "SELECT ID FROM Manga;";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            //Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                int i = 0;
                manga a1 = new manga();
                while (dr.Read())
                {
                    //taking id a pulling all data from manga to add to list
                    i = dr.GetInt32(0) ;
                    a1 = new manga();
                    a1.selectSingleManga(i);
                    arrL.add(a1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
        //takes two string one the keyword and the other the col in the database used to find the search results
        public void search(string keyWord, string col)
        {
            DBSetup();
            cmd = "Select * from Manga Where " + col + " Like '%" + keyWord + "%';";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                int i = 0;
                manga a1 = new manga();
                while (dr.Read())
                {
                    //taking id a pulling all data from manga to add to list
                    i = dr.GetInt32(0);
                    a1 = new manga();
                    a1.selectSingleManga(i);
                    arrL.add(a1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }
    }
}

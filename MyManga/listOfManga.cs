/*************************
 * 	    Julian A P.	     *
 *	   Manga project     *
 * C# and .NET Framework *
 *      using MVS        *
 ************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManga
{
    public class listOfManga
    {
        public int count = 0;
        public ArrayList arrlist = new ArrayList();
        //Adds an manga the the list
        public void add(manga a)
        {
            arrlist.Add(a);
            count++;
        }
        //Uses Display method in manga the display each manga in the list.
        public void display()
        {
            foreach(manga a in arrlist)
            {
                a.display();
            }
        }
    }
}

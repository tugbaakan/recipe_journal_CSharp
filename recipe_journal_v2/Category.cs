using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_journal_v2
{
    // create a class for Categories
    public class Category
    {
        public int ID;
        public string name;
        public string[] ignorewords;
        public string[] keywords;

        public Category(int ID_inp, string name_inp, string[] keywords_inp
            , string[] ignorewords_inp)
        {
            ID = ID_inp;
            name = name_inp;
            keywords = keywords_inp;
            ignorewords = ignorewords_inp;
        }

    }
}

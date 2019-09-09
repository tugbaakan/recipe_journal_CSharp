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
        private int ID;
        private string name;
        private string[] ignorewords;
        private string[] keywords;

        public Category(int ID_inp, string name_inp, string[] keywords_inp
            , string[] ignorewords_inp)
        {
            ID = ID_inp;
            name = name_inp;
            keywords = keywords_inp;
            ignorewords = ignorewords_inp;
        }

        public string[] Ignorewords { get { return this.ignorewords; } set { this.ignorewords = value; } }
        public string[] Keywords { get { return this.keywords; } set { this.keywords = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
    }
}

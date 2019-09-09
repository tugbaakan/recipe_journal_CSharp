using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_journal_v2
{
    // create a class for recipes
    public class Recipe
    {
        private string name;
        private string[] ingredients;
        private List<Category> category;

        //Parameterized constructor
        public Recipe(string name_inp, string[] ingredients_inp, Category[] categories_inp)
        {
            name = name_inp;
            ingredients = ingredients_inp;
            this.setCategory(categories_inp);
        }

        public string Name { get { return this.name; } set { this.name = value; } }
        public string[] Ingredients { get { return this.ingredients; } set { this.ingredients = value;  } }
        public List<Category> Category { get { return category; } }

        public void setCategory(Category[] categories)
        {
            this.category = new List<Category>();
            // loop for all categories
            foreach (var cate in categories)
            {
                // loop for all ingredients
                foreach (var ingr in this.ingredients)
                {
                    // loop for all the words to be ignored
                    foreach (var kw0 in cate.Ignorewords)
                    {
                        if (ingr.Contains(kw0) == false)
                        {
                            //loop for all keywords
                            foreach (var kw in cate.Keywords)
                            {
                                if (ingr.Contains(kw))
                                {
                                    this.category.Add(cate);
                                    goto BREAK;

                                }
                            }
                        }
                    }

                }
            BREAK: ;
            }
        }


    }

       
}

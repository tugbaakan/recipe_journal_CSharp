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
        public string name;
        public string[] ingredients;
        public List<Category> category = new List<Category>();

        //Parameterized constructor
        public Recipe(string name_inp, string[] ingredients_inp, Category[] categories_inp)
        {
            name = name_inp;
            ingredients = ingredients_inp;
            this.setCategory(categories_inp);
        }

        // method to set the category of the recipe
        public void setCategory(Category[] categories)
        {
            // loop for all categories
            foreach (var cate in categories)
            {
                // loop for all ingredients
                foreach (var ingr in ingredients)
                {
                    // loop for all the words to be ignored
                    foreach (var kw0 in cate.ignorewords)
                    {
                        if (ingr.Contains(kw0) == false)
                        {
                            //loop for all keywords
                            foreach (var kw in cate.keywords)
                            {
                                if (ingr.Contains(kw))
                                {
                                    category.Add(cate); 
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_journal_v2
{
    // Developer: Tugba Akan
    // Recipe Journal: A journal keeping your recipes in categories by the ingredients
    // letting you enter a new recipe
    // listing the recipes of the desired category
    
    // The recipes are taken from the website https://www.jamieoliver.com/

    // Version 1 : The categories are: Beef, Chicken, Vegetables
    // if you would like to add a new recipe, put the text document into the folder 
    // that the code runs and run the code. It will load all the text documents 
    // including the new one. You can run the jupyter notebook
    // or the py file from the command line
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // Definition of categories.
            // Keywords are the one that help us to find what is the main ingredient.
            // Ignore words are the ones that misdirect us from the main ingredient. e.g. chicken stock.
            // Beef
            string[] kws_1 = { "lamb", " lamb ", " lamb\n", "steak", "beef" };
            string[] igs_1 = { "stock" };
            Category cate1 = new Category(1, "Beef", kws_1, igs_1);
 
            // Chicken 
            string[] kws_2 = { "chicken" };
            string[] igs_2 = { "stock" };
            Category cate2 = new Category(2, "Chicken", kws_2, igs_2);
            
            // Vegetable
            string[] kws_3 = { "parsnip", "parsnips", "beetroot", "broccoli", "cauliflower"
            , "courgette", "courgettes", "cucumber", "lettuce", "spinach", "runner beans"};
            string[] igs_3 = { "stock" };
            Category cate3 = new Category(3, "Vegetables", kws_3, igs_3);
            Category[] categories = { cate1, cate2, cate3 };

            // Import txt files and create a list of the objects of the Recipe class.
            List<Recipe> recipes = new List<Recipe>();
            int i = 0;
            // We assume that there are at most 20 recipes.
            for (i = 1; i <= 20; i++)
            {
                try
                {
                    /* Read each line of the file into a string array. Each element
                    of the array is one line of the file. */
                    string[] new_recipe = System.IO.File.ReadAllLines(@"C:\Users\tugbaa\Documents\GitHub\recipe_journal_golang\recipe" + i + ".txt");
                    int ing_index = 0;
                    int j = 0;
                    for (j = 0; j < new_recipe.Length; j++)
                    {
                        // take the below line of 'Ingredients' for ingredient list
                        // find the index and assign it to ing_index
                        if (new_recipe[j] == "Ingredients")
                        {
                            ing_index = j;
                            break;
                        }
                    }
                    Recipe rec = new Recipe(new_recipe[0], SubArray(new_recipe, ing_index, new_recipe.Length - ing_index), categories);
                    recipes.Add(rec);
                }
                catch (System.IO.FileNotFoundException e1)
                {
                    continue;
                }
            }

            // Create a list for each category type and fill them up.
            List<Recipe> list_meat_2 = new List<Recipe>();
            List<Recipe> list_chicken_2 = new List<Recipe>();
            List<Recipe> list_veggies_2 = new List<Recipe>();
            List<Recipe> list_other_2 = new List<Recipe>();
            
            foreach( var rec in recipes){
                foreach ( var cate in rec.category){
                    if (cate.name == "Beef"){
                        list_meat_2.Add(rec);
                    }
                    else if (cate.name == "Chicken")
                    {
                        list_chicken_2.Add(rec);
                    }
                    else if (cate.name == "Vegetables")
                    {
                        list_veggies_2.Add(rec);
                    }
                    else {
                        list_other_2.Add(rec);
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(list_meat_2, list_chicken_2, list_veggies_2, list_other_2));

        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }


    }
}

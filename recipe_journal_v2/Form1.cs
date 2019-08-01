using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_journal_v2
{
    public partial class Form1 : Form
    {

        List<Recipe> list_meat = new List<Recipe>();
        List<Recipe> list_chicken = new List<Recipe>();
        List<Recipe> list_veggies = new List<Recipe>();
        List<Recipe> list_other = new List<Recipe>();

        public Form1(List<Recipe> list_meat_inp, List<Recipe> list_chicken_inp
            , List<Recipe> list_veggies_inp, List<Recipe> list_other_inp )
        {
            InitializeComponent();
            list_meat = list_meat_inp;
            list_chicken = list_chicken_inp;
            list_veggies = list_veggies_inp;
            list_other = list_other_inp;
        }

        // method created to fill the List Box
        private void LoadIntoListBox(List<Recipe> inputList )
        {
            listBox1.Items.Clear(); 
            
            foreach (var item in inputList)
            { 
                listBox1.Items.Add(item.name );
            }

        }

        // Inıtially, all recipes will be shown in the List box
        private void Form1_Load(object sender, EventArgs e)
        {

            List<Recipe> list_all = new List<Recipe>();
            list_all.AddRange(list_meat);
            list_all.AddRange(list_chicken);
            list_all.AddRange(list_veggies);
            list_all.AddRange(list_other);

            LoadIntoListBox(list_all);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_meat_Click(object sender, EventArgs e)
        {
            LoadIntoListBox(list_meat);
        }

        private void button_chicken_Click(object sender, EventArgs e)
        {
            LoadIntoListBox(list_chicken);
        }

        private void button_vegetable_Click(object sender, EventArgs e)
        {
            LoadIntoListBox(list_veggies);
        }

        private void button_other_Click(object sender, EventArgs e)
        {
            LoadIntoListBox(list_other);
        }


    }
}

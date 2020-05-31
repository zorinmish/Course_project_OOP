using CourseWork_att_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWork_att_1
{
    public partial class New_recipe_window : Form
    {
        public Recipe recipe;
        public New_recipe_window()
        {
            InitializeComponent();
        }
        public New_recipe_window(Recipe res) : this()
        {
            recipe = res;
            nameBox.Text = recipe.Name;
            servBox.Text = recipe.Serving;
            if (recipe.Products.Count > 4)
            {
                textBox1.Text = recipe.Products[4].Product.Name;
                unitBox5.Text = recipe.Products[4].Product.Unit;
                numericUpDown1.Value = Convert.ToInt32(Math.Floor(recipe.Products[4].number));
            }
            if (recipe.Products.Count > 3)
            {
                textBox2.Text = recipe.Products[3].Product.Name;
                unitBox4.Text = recipe.Products[3].Product.Unit;
                numericUpDown2.Value = Convert.ToInt32(Math.Floor(recipe.Products[3].number));
            }
            if (recipe.Products.Count > 2)
            {
                textBox3.Text = recipe.Products[2].Product.Name;
                unitBox3.Text = recipe.Products[2].Product.Unit;
                numericUpDown3.Value = Convert.ToInt32(Math.Floor(recipe.Products[2].number));
            }
            if (recipe.Products.Count > 1)
            {
                textBox4.Text = recipe.Products[1].Product.Name;
                unitBox2.Text = recipe.Products[1].Product.Unit;
                numericUpDown4.Value = Convert.ToInt32(Math.Floor(recipe.Products[1].number));
            }
            if (recipe.Products.Count > 0)
            {
                textBox5.Text = recipe.Products[0].Product.Name;
                unitBox1.Text = recipe.Products[0].Product.Unit;
                numericUpDown5.Value = Convert.ToInt32(Math.Floor(recipe.Products[0].number));
            }
            if (recipe.Actions.Count > 0)
            {
                Action1.Text = recipe.Actions[0].Description;
                Time1.Value = recipe.Actions[0].Time_in_minutes;
            }
            if (recipe.Actions.Count > 1)
            {
                Action2.Text = recipe.Actions[1].Description;
                Time2.Value = recipe.Actions[1].Time_in_minutes;
            }
            if (recipe.Actions.Count > 2)
            {
                Action3.Text = recipe.Actions[2].Description;
                Time3.Value = recipe.Actions[2].Time_in_minutes;
            }
            if (recipe.Actions.Count > 3)
            {
                Action4.Text = recipe.Actions[3].Description;
                Time4.Value = recipe.Actions[3].Time_in_minutes;
            }
            if (recipe.Actions.Count > 4)
            {
                Action5.Text = recipe.Actions[4].Description;
                Time5.Value = recipe.Actions[4].Time_in_minutes;
            }
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_recipe_button_Click(object sender, EventArgs e)
        {
            //adding new recipe
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (recipe == null)
            {
                recipe = new Recipe();
            }
            recipe.Name = nameBox.Text;
            recipe.Serving = servBox.Text;
            if (textBox5.Text != "")
            {
                recipe.Products[0].Product.Name= textBox5.Text;
                recipe.Products[0].Product.Unit = unitBox1.Text;
                recipe.Products[0].number = Convert.ToDouble(numericUpDown5.Value);
            }
            if (textBox4.Text != "")
            {
                recipe.Products[1].Product.Name = textBox4.Text;
                recipe.Products[1].Product.Unit = unitBox2.Text;
                recipe.Products[1].number = Convert.ToDouble(numericUpDown4.Value);
            }
            if (textBox3.Text != "")
            {
                recipe.Products[2].Product.Name = textBox3.Text;
                recipe.Products[2].Product.Unit = unitBox3.Text;
                recipe.Products[2].number = Convert.ToDouble(numericUpDown3.Value);
            }
            if (textBox2.Text != "")
            {
                recipe.Products[3].Product.Name = textBox2.Text;
                recipe.Products[3].Product.Unit = unitBox4.Text;
                recipe.Products[3].number = Convert.ToDouble(numericUpDown2.Value);
            }
            if (textBox1.Text != "")
            {
                recipe.Products[4].Product.Name = textBox1.Text;
                recipe.Products[4].Product.Unit = unitBox5.Text;
                recipe.Products[4].number = Convert.ToDouble(numericUpDown1.Value);
            }
            if (Action1.Text != "")
            {
                recipe.Actions[0].Description = Action1.Text;
                recipe.Actions[0].Time_in_minutes = Convert.ToInt32(Time1.Value);
            }
            if (Action2.Text != "")
            {
                recipe.Actions[1].Description = Action2.Text;
                recipe.Actions[1].Time_in_minutes = Convert.ToInt32(Time2.Value);
            }
            if (Action3.Text != "")
            {
                recipe.Actions[2].Description = Action3.Text;
                recipe.Actions[2].Time_in_minutes = Convert.ToInt32(Time3.Value);
            }
            if (Action1.Text != "")
            {
                recipe.Actions[3].Description = Action4.Text;
                recipe.Actions[3].Time_in_minutes = Convert.ToInt32(Time4.Value);
            }
            if (Action1.Text != "")
            {
                recipe.Actions[4].Description = Action5.Text;
                recipe.Actions[4].Time_in_minutes = Convert.ToInt32(Time5.Value);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_recipe_window_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

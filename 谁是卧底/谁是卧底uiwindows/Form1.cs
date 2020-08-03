using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 谁是卧底uiwindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            int randoflabel=(rd.Next()%5)+1;
            int randword = (rd.Next()%1)+0;
            string[] wodiword={"a","b"};
            string[] pingminword={ "c","d"};
            string[,] miaoshupingmin = { { "1", "2" }, { "1", "2" }, { "1", "2" }, { "1", "2" } , { "1", "2" } };
            string[] miaoshuwodi = { "3", "4" };
            /*if (randoflabel == 1)
            {
                word1.Text = wodiword[randword];
                word2.Text = pingminword[randword];
                word3.Text = pingminword[randword];
                word4.Text = pingminword[randword];
                word5.Text = pingminword[randword];
            }
            if (randoflabel == 5)
            {
                word1.Text = pingminword[randword];
                word2.Text = pingminword[randword];
                word3.Text = pingminword[randword];
                word4.Text = pingminword[randword];
                word5.Text = wodiword[randword];
            }
            if (randoflabel == 2)
            {
                word1.Text = pingminword[randword]; ;
                word2.Text = wodiword[randword];
                word3.Text = pingminword[randword];
                word4.Text = pingminword[randword];
                word5.Text = pingminword[randword];
            }
            if (randoflabel == 3)
            {
                word1.Text = pingminword[randword];
                word2.Text = pingminword[randword];
                word3.Text = wodiword[randword];
                word4.Text = pingminword[randword];
                word5.Text = pingminword[randword];
            }
            if (randoflabel == 4)
            {
                word1.Text = pingminword[randword];
                word2.Text = pingminword[randword];
                word3.Text = pingminword[randword];
                word4.Text = wodiword[randword];
                word5.Text = pingminword[randword];
            }*/
            string[] word= new string[6]{ pingminword[randword], pingminword[randword], pingminword[randword], pingminword[randword], pingminword[randword] , pingminword[randword] };
            word[randoflabel]= wodiword[randword];
            word1.Text = word[0];
            //textBox1.Text = miaoshupingmin[1, randword];
            if (randoflabel != 2) textBox2.Text = miaoshupingmin[1, randword]; else textBox2.Text = miaoshuwodi[randword];
            if (randoflabel != 3) textBox3.Text = miaoshupingmin[2, randword]; else textBox2.Text = miaoshuwodi[randword]; 
            if (randoflabel != 4) textBox4.Text = miaoshupingmin[3, randword]; else textBox2.Text = miaoshuwodi[randword]; 
            if (randoflabel != 5) textBox5.Text = miaoshupingmin[4, randword]; else textBox2.Text = miaoshuwodi[randword]; 
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

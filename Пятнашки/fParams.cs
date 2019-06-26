using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пятнашки
{
    public partial class fParams : Form
    {
        private int chosenSize; 
        public fParams()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
                chosenSize = 3;
            if (listBox1.SelectedIndex == 1)
                chosenSize = 4;
            if (listBox1.SelectedIndex == 2)
                chosenSize = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(chosenSize == 0)
            {
                MessageBox.Show("Вы не выбрали размер! Текущий размер установлен по умолчанию.", "Сообщение",
                    MessageBoxButtons.OK);
                MainMenu.GameSize = 4;
            }
            else
                MainMenu.GameSize = chosenSize;

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu.GameSize = 4;
            this.Hide();
        }

        private void fParams_Load(object sender, EventArgs e)
        {

        }
    }
}

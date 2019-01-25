using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadInput {
    public partial class Form1 : Form  {
        public Form1() {
            InitializeComponent();
        }//end if


        private void button1_Click(object sender, EventArgs e) {
            int Temp = 0;
            if (! int.TryParse(textBox1.Text, out Temp)) {
                textBox1.BackColor = Color.Gold;
                textBox1.Focus();
            }else{       
                MessageBox.Show("Success");
            }//end if
        }//end method

        //change color back to white
        private void textBox1_TextChanged(object sender, EventArgs e) {
                textBox1.BackColor = Color.White;
        }//end method

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show(openFileDialog1.FileName);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // show the dialog 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //add code to save file
        }
    }
}

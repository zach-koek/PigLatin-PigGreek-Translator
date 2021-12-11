using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class frmTranslator : Form
    {
        PigLatin pig = new PigLatin();
        PigGreek greek = new PigGreek();
        public frmTranslator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            txtbxOutput.Text = "";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            txtbxOutput.Text = "";

            if (rdbtnPigGreek.Checked)
            {
                
                string text = txtbxInput.Text;
                txtbxOutput.Text = "";

                if (text.StartsWith(" "))
                {
                     MessageBox.Show("You cant start you phrase with a space.");
                }
                else
                {
                    txtbxOutput.Text = greek.Translate(text); 
                }
             
            }
            if (rdbtnPigLatin.Checked)
            {
                
                
                string text = txtbxInput.Text;
                if (text.StartsWith(" "))
                {
                    MessageBox.Show("You cant start your phrase with a space.");
                }
                else
                {
                    txtbxOutput.Text = "";
                    txtbxOutput.Text = pig.Translate(text);
                }
                
            }
            
        }

        private void rdbtnPigLatin_CheckedChanged(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            lbllangTrans.Text = "Pig Latin Translation.";
        }

        private void rdbtnPigGreek_CheckedChanged(object sender, EventArgs e)
        {
            txtbxOutput.Clear();
            lbllangTrans.Text = "Pig Greek Translation.";
        }
    }
}

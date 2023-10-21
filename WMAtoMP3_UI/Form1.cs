using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMAtoMP3_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            Convertor convertor = new Convertor(textBox1.Text, textBox2.Text);
            LBLdata.Text = "Running...          ";
            convertor.Run();
            LBLdata.Text = "Finished";

        }

        private void BTNselectwma_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                
                DialogResult result = folderBrowserDialog.ShowDialog();

                
                if (result == DialogResult.OK)
                {
                 
                    textBox1.Text = folderBrowserDialog.SelectedPath;
                }
            }

        }

        private void BTNselectmp3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                
                DialogResult result = folderBrowserDialog.ShowDialog();

                
                if (result == DialogResult.OK)
                {
                    
                    textBox2.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}

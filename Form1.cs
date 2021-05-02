using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetItDoneList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnStoreInfo_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents | * .txt ", ValidateNames = true }) //Saving file
            {
                if (sfd.ShowDialog() == DialogResult.OK) //If Statement
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(txbInfo.Text); //Waits for method to return result
                        MessageBox.Show("Your Information Has Been Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); //Display message
                    }


                }
            }
        }

        

        private async void btnView_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents | * .txt ", ValidateNames = true, Multiselect = false }) //Opening a file
            {
                if (ofd.ShowDialog() == DialogResult.OK) //If Statement
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        txbInfo.Text = await sr.ReadToEndAsync(); //Waits for method to return result
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Close Application
        }
    }
    }


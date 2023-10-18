using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeGreskamaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            try
            {
                int godRod = Convert.ToInt16(textUnos1.Text);

                textIspis.Text = godRod.ToString();
                textUnos1.Clear();
            }

            catch(Exception greska)
            {
                DialogResult odabir = MessageBox.Show("Molimo vas da upišete broj!\nŽelite li izbrisati postojeći unos?", "Pogrešan Unos!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch(odabir) 
                {
                    case DialogResult.Yes:
                        textUnos1.Clear(); break;
                    case DialogResult.No:
                        break;


                       
                }

                textUnos1.Select();

            }
            
        }
    }
}

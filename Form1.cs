using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFsemana2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            label1.Text = "CHRISTIAN ALEXANDER MONTENEGRO RODRÍGUEZ USTS023419";
            label2.Text = "NILDERSON ALEXIS CHÁVEZ BARAHONA USSS012222";
            label3.Text = "DIEGO ENMANUEL ZEPEDA RENDEROS USSS017922";
            label4.Text = "EDWIN EMERSON LÓPEZ HERNÁNDEZ USSS017222";
            label5.Text = "HENRY ANDERSON SÁNCHEZ CORTEZ USSS030722";
            label6.Text = "FERNANDO JOSÉ LÓPEZ TORRES USTS002422";

            label1.Visible = true;
        }
    }
}

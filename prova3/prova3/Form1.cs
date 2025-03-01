using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace prova3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lbl_testo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int n = 0;
            aggnum(n);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int n = 1;
            aggnum(n);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int n = 2;
            aggnum(n);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int n = 3;
            aggnum(n);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int n = 4;
            aggnum(n);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            int n = 5;
            aggnum(n);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int n = 6;
            aggnum(n);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int n = 7;
            aggnum(n);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            int n = 8;
            aggnum(n);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int n = 9;
            aggnum(n);
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {

        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {

        }

        private void btnMoltiplicazione_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisione_Click(object sender, EventArgs e)
        {

        }
        private void btnCancella_Click(object sender, EventArgs e)
        {

        }

        private void btnUguale_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aggnum(int n)
        {
            lbl_testo.Text += n.ToString();
        }

    }
}

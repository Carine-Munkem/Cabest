using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion
{
    public partial class Form1 : Form
    {
        private string strInput1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string strInput1 = "Hello world";
            string strInput2 = "@@";
            string strInput3 = "he@@";
            string stroutput = "he@@";



             strInput1 = txtInput1.Text; //Input text
             strInput2 = txtInput2.Text; //substring Extraction
             strInput3 = txtInput3.Text; //users enter new string
           stroutput = txtOutput.Text; //output (Input1-Input2+Input3)

            strInput2 = strInput1.Substring(0, 0);
            txtInput2.Text = strInput2.ToString();

            int intInput1; //calculate  the length of user types in
            intInput1 = txtInput1.Text.Length;
            txtInput1.Text = intInput1.ToString();

            int intInput2; //calculate the length of new substrin
            intInput2 = txtInput2.Text.Length;
            txtInput2.Text = intInput2.ToString();

            int intInput3; //to calculate the length of new text user types in
            intInput3 = txtInput3.Text.Length;
            txtInput3.Text = intInput3.ToString();


            txtOutput.Text = stroutput.ToString();


        }
    }
}

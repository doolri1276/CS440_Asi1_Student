using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPconcepts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {
            //read the two test scores
            int test1 = int.Parse(txtTest1.Text);
            int test2 = int.Parse(txtTest2.Text);

            //create a student object, set the
            //fields in it and call compute grade
            Student s1 = new Student();
            s1.Test1 = test1;
            s1.Test2 = test2;
            String grade = s1.ComputeGrade();
            MessageBox.Show("Grade : " + grade);

        }
    }
}

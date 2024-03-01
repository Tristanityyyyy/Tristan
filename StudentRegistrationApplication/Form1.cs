using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstText.Text;
            string lastName = lastText.Text;
            string miName = miText.Text;
            string msg1 = "Student Name: " + firstName + " " + miName + " " + lastName;

            string gender = "";
            if (radioButton1.Checked == true)
            {
                gender = "Male";
               
            }
            else if(radioButton2.Checked == true)
            {
                gender = "Female";
            }
            string msg2 = "Gender: " + gender;
            string msg3 = "Date of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
            string msg4 = "Program: " + comboBox4.Text;
            MessageBox.Show(msg1 + "\n" + msg2 + "\n" + msg3 + "\n" + msg4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            while (a <= 31) {
                comboBox1.Items.Add(a);
                a++;
            }

            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            
            foreach (string twelve in months){
                comboBox2.Items.Add(twelve);
            }

            int c = 1900;
            while (c <= 2024)
            {
                comboBox3.Items.Add(c);
                c++;
            }

            ArrayList courses = new ArrayList();
            courses.Add("Bachelor of Science in Computer Science");
            courses.Add("Bachelor of Science in Information Technology");
            courses.Add("Bachelor of Science in Information Systems");
            courses.Add("Bachelor of Science in Computer Engineering");
            
            int d = 0;
            while (d <= 3) {
                comboBox4.Items.Add(courses[d]);
                d++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mon_pass_sql_express
{
    public partial class add_edit : Form
    {
        public add_edit()
        {
            InitializeComponent();
        }

        private void add_edit_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CalendarForeColor = Color.Navy;
            dateTimePicker1.CalendarTitleForeColor = Color.Navy;

            if (variables.add_edit_)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                numericUpDown1.Value = 0;
                dateTimePicker1.Value = DateTime.Now;

            }
            else
            {
                textBox1.Text= variables.textBox1_Text;
                textBox2.Text = variables.textBox2_Text;
                textBox3.Text = variables.textBox3_Text;
                textBox4.Text = variables.textBox4_Text;
                textBox5.Text = variables.textBox5_Text;
                textBox6.Text = variables.textBox6_Text;
                textBox7.Text = variables.textBox7_Text;
                numericUpDown1.Value= variables.numericUpDown1_;
                dateTimePicker1.Value= variables.dateTimePicker_;
    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            variables.yyes = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || (Convert.ToString(numericUpDown1.Value) == "0"))
            {

                MessageBox.Show("ყველა ველი შევსებული უნდა იყოს!", "ყურადღება!", MessageBoxButtons.OK);
            }
            else
            {
                variables.ssave_ok = true;
                variables.yyes = true;
                //    variables.textBox1_Text = ;
                //variables.textBox2_Text = textBox2.Text;
                //variables.textBox3_Text = textBox3.Text;
                //variables.textBox4_Text = textBox4.Text;
                //variables.textBox5_Text = textBox5.Text;
                //variables.textBox6_Text = textBox6.Text;
                //variables.textBox7_Text = textBox7.Text;
                //variables.textBox8_Text = textBox8.Text;
                //variables.numericUpDown1_ = numericUpDown1.Value;


                variables.textBox1_Text = textBox1.Text;
                variables.textBox2_Text = textBox2.Text;
                variables.textBox3_Text = textBox3.Text;
                variables.textBox4_Text = textBox4.Text;
                variables.textBox5_Text = textBox5.Text;
                variables.textBox6_Text = textBox6.Text;
                variables.textBox7_Text = textBox7.Text;
                variables.numericUpDown1_ = numericUpDown1.Value;
                variables.dateTimePicker_ = dateTimePicker1.Value;
                Close();
            }
            
        }
    }
}

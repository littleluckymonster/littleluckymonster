using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.dataSet1.Gender);
            // TODO: This line of code loads data into the 'dataSet1.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.dataSet1.Country);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox6.Text)
            {
                MessageBox.Show("Sorry :c");
                return;
            }

            string cs = "Data Source=127.0.0.1;Initial Catalog=wwww;User ID=student;Password=student";
            SqlConnection c = new SqlConnection(cs);
            c.Open();

            string cc = (string)XXXcountry.SelectedValue;
            string em = textBox1.Text;
            string gen = (string)comboBox2.SelectedValue;
            string dob = dateTimePicker1.Value.ToString();
            string pass = textBox2.Text;
            string fn = textBox5.Text;
            string ln = textBox4.Text;



            string s = "insert into [Runner] ([Email], [Gender], [DateOfBirth], [CountryCode]) values('" + em + "', '" + gen + "', '" + dob + "', '" + cc + "');";
            MessageBox.Show(s);
            SqlCommand x = new SqlCommand(s, c);
            x.ExecuteNonQuery();

            string s1 = "insert into [User] ([Email], [Password], [FirstName], [LastName]) values('" + em + "', '" + pass + "', '" + fn + "', '" + ln + "', R);";
            MessageBox.Show(s1);
            SqlCommand x1 = new SqlCommand(s1, c);
            x.ExecuteNonQuery();

            c.Close();

            this.Hide();
            new Form5().ShowDialog();
            this.Show();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            x.Text = "";
        }

        private void XXXcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

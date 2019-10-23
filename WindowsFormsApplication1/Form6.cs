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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox x = (TextBox) sender;
            x.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();  
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString(); 
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Runner' table. You can move, or remove it, as needed.
            this.runnerTableAdapter.Fill(this.dataSet1.Runner);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=127.0.0.1;Initial Catalog=wwww;User ID=student;Password=student";
            SqlConnection c = new SqlConnection(cs);
            c.Open();

            string sn = textBox1.Text;
            string am = textBox7.Text;
            string rID = ((int)comboBox1.SelectedValue).ToString();

            string s = "insert into [Sponsorship] ([SponsorName], [Amount], [RegistrationId]) values('" + sn + "', " + am + ", " + rID + ");";
            MessageBox.Show(s);
            SqlCommand x = new SqlCommand(s, c);
            x.ExecuteNonQuery();

            c.Close();

            Form7 all = new Form7();
            all.label3.Text = comboBox1.Text;
            all.label16.Text = textBox7.Text + "$";
            all.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

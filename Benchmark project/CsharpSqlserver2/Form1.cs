using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CsharpSqlserver2
{
    public partial class Form1 : Form
    {

        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void inputText(object sender, EventArgs e)
        {

        }
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private void Insert(object sender, EventArgs e)
        {
            bool check1, check2, check3;
            check1 = IsDigitsOnly(StudentNumber1.Text);
            check2 = IsDigitsOnly(StudentNumber2.Text);
            check3 = IsDigitsOnly(ReferanceNumberText.Text);
            if (check1 == false || check2 == false || check3 == false)
            {
                MessageBox.Show("Invalid Phone Number");
                return;
            }

            
           
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");


            cmd = new SqlCommand("INSERT INTO Registration ([GR.No],StudentName,FatherName,StudentPhoneNumber1,StudentPhoneNumber2,ReferenceName,ReferenceNumber,AdmissionDate,Program) VALUES ('" + this.GRnumtext.Text + "','" + this.StudentNameText.Text + "','" + this.FatherNameText.Text + "','" + this.StudentNumber1.Text + "','" + this.StudentNumber2.Text + "','" + this.ReferanceNametext.Text + "','" + this.ReferanceNumberText.Text + "','" + this.dateTimePicker1.Text + "','" + this.ProgramText.Text + "')", con);
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
               // MessageBox.Show("Saved");
                while (dr.Read())
                { }
                //GRnumtext.Clear();
                //StudentNameText.Clear();
                //FatherNameText.Clear();
                //StudentNumber1.Clear();
                //StudentNumber2.Clear();
                //ReferanceNametext.Clear();
                //ReferanceNumberText.Clear();
                //ProgramText.Clear();
                con.Close();
               // new Form2(GRnumtext.Text).Show();
               // this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
            cmd = new SqlCommand("INSERT INTO FeePayment ([Roll no],Program) VALUES ('" + this.GRnumtext.Text + "','" + this.ProgramText.Text + "')", con);


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                { }
                //GRnumtext.Clear();
                //StudentNameText.Clear();
                //FatherNameText.Clear();
                //StudentNumber1.Clear();
                //StudentNumber2.Clear();
                //ReferanceNametext.Clear();
                //ReferanceNumberText.Clear();
                //ProgramText.Clear();
                con.Close();
                new Form2(GRnumtext.Text).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


        }

        public void inputText(object sender, UICuesEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelClick(object sender, EventArgs e)
        {

        }

        private void enable(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormA().Show();
            this.Hide();
        }

        private void StudentNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsharpSqlserver2
{
    public partial class Form2 : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        
        private SqlDataReader dr;
        int total;
        string tempForGRno;
        Form1 frm1 = new Form1();
        public Form2( string str)
        {
            InitializeComponent();
            tempForGRno = str;
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void input(object sender, EventArgs e)
        {
           
        }

        private void Insert(object sender, EventArgs e)
        {

            cmd = new SqlCommand("UPDATE Registration SET AdmissionFeeAmount='" + this.AdmissionAmount.Text + "',MonthlyFeeAmount='" + this.MonthlyAmount.Text + "',CertificateFeeAmount='" + this.CertificateAmount.Text + "',ExaminationFeeAmount='" + this.ExaminationAmount.Text + "',TotalFeeAmount='" + total + "' WHERE [GR.No] = '" + int.Parse(tempForGRno) + "'", con);


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                { }
                AdmissionAmount.Clear();
                MonthlyAmount.Clear();
                CertificateAmount.Clear();
                ExaminationAmount.Clear();
                new FormA().Show();
                this.Hide();
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
               


        }

        private void LabelClick(object sender, EventArgs e)
        {

        }
        public void TotalAmountOfFees(object sender, EventArgs e)
        {
           
        }
        private void BackToForm1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void TotalAmountOfFees()
        {

        }

        private void TotalAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total = int.Parse(AdmissionAmount.Text) + int.Parse(MonthlyAmount.Text) + int.Parse(CertificateAmount.Text) + int.Parse(ExaminationAmount.Text);

            TotalAmountDisplay.Text = total.ToString();
          

        }
    }
}

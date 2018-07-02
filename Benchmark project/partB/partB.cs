using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace partB
{
    public partial class partB : Form
    {

        private SqlCommand cmd;
        private SqlConnection con;
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public partB()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LabelClick(object sender, EventArgs e)
        {

        }

        private void input(object sender, EventArgs e)
        {

        }

        private void Insert(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO FeeStructure (AdmissionFeeAmount,MonthlyFeeAmount,CertifucateFeeAmount,ExaminationFeeAmount,TotalFeeAmount) VALUES ('"+this.AdmissionAmount.Text+"','"+this.MonthlyAmount.Text+"','"+this.CertificateAmount.Text+"','"+this.ExaminationAmount.Text+"','"+this.TotalAmount.Text+"')", con);

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AdmissionAmount.Clear();
            MonthlyAmount.Clear();
            CertificateAmount.Clear();
            ExaminationAmount.Clear(); 
            TotalAmount.Clear();         

        }
    }
}

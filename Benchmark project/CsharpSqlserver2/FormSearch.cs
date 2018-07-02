using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsharpSqlserver2
{
    public partial class FormSearch : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            SearchText();

        }
        public void SearchText()
        {
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");

           con.Open();
            cmd = new SqlCommand("SELECT * FROM Registration", con);

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void SearchByRollNo(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");


     
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
                con.Close();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchByRollNo()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SearchByRollNo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new FormA().Show();
            this.Hide();
        }
    }
}

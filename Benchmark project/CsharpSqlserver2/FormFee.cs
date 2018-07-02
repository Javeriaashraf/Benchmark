using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CsharpSqlserver2
{
    public partial class FormFee : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader dr;
        public string tempForRecieptNo;
        private SqlDataAdapter da;
        private DataSet ds;
        int MaxRows = 0;
        public string tempRollNum;
        string tempForChangingRecieptID;
        int tempforrecieptid;
                                                                                       
        
        public FormFee()
        {
            InitializeComponent();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FeeSubmission(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");
            ds = new DataSet();
            string cmnd = ("SELECT * FROM IDforReciept");
            da = new SqlDataAdapter(cmnd, con);
            con.Open();
            da.Fill(ds, "IDforReciept");
           // MaxRows = ds.Tables["Reciept"].Rows.Count;
            Navigation1();
            tempforrecieptid = int.Parse( tempForChangingRecieptID) + 1;
            con.Close();
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");

            cmd = new SqlCommand("UPDATE IDforReciept SET ID='"+ tempforrecieptid +"'  WHERE flag='1'", con);
            cmd.Connection = con;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();

               // MessageBox.Show("Saved");
                while (dr.Read())
                { }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
            //con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");

            cmd = new SqlCommand("INSERT INTO Reciept (SlipNumber,GRNo,SubjectOfFee,Fee,Date) VALUES ('" +tempforrecieptid + "','" + this.StudentIDInput.Text + "','" + this.comboBox1.Text + "','" + this.FeeInput.Text + "','" + this.dateTimePicker1.Text + "')", con);
            cmd.Connection = con;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                
                MessageBox.Show("Saved");
                while (dr.Read())
                { }
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            

            cmd = new SqlCommand("UPDATE FeePayment SET [" + comboBox1.Text + "]='" + this.FeeInput.Text + "'WHERE [Roll no]= '" + this.StudentIDInput.Text + "'", con);


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
               // MessageBox.Show("Saved");
                while (dr.Read())
                { }
               // StudentIDInput.Clear();
                
                //FeeInput.Clear();


                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");
            ds = new DataSet();
             cmnd = ("SELECT * FROM Reciept");
            da = new SqlDataAdapter(cmnd, con);
            con.Open();
            da.Fill(ds, "Reciept");
            MaxRows = ds.Tables["Reciept"].Rows.Count;
            Navigation();

            con.Close();
          
             
        }
        public void Navigation1()
        {

            DataRow drow = ds.Tables["IDforReciept"].Rows[0];
            tempForChangingRecieptID = drow.ItemArray.GetValue(0).ToString();
        }
        public void Navigation()
        {
            
            DataRow drow = ds.Tables["Reciept"].Rows[MaxRows-1];
            tempForRecieptNo = drow.ItemArray.GetValue(0).ToString();
        }

        private void FormFee_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new FormA().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             tempRollNum=this.StudentIDInput.Text;
            new FormPrint(tempRollNum).Show();
            this.Hide();
        }

        private void StudentIDInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

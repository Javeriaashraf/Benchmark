using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CsharpSqlserver2
{
    public partial class FormPrint : Form
    {
        private SqlCommand cmd;
        private SqlConnection con;
        private SqlDataReader dr;
        string TempForRollNo;
        string tempForRecieptNo;
       public string RecieptNum, PaymentDate, StdName, FathName, Prg, GRNum, SubjectOfFee,FeeText;
        private SqlDataAdapter da;
        private DataSet ds;
        int MaxRows = 0;

        public FormPrint(string str)
        {
            InitializeComponent();
            TempForRollNo = str;
           // tempForRecieptNo = str1;
            ////select from registration table and saved the required values in variables
            //con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");
            //ds = new DataSet();
            //string cmnd = ("SELECT * FROM Registration ");
            //da = new SqlDataAdapter(cmnd, con);
            //con.Open();
            //da.Fill(ds, "Registration");
            //MaxRows = ds.Tables["Registration"].Rows.Count;
            //Navigation();

            //con.Close();
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");
            cmd = new SqlCommand("SELECT * FROM Registration WHERE [GR.No]='" + TempForRollNo + "'", con);
            cmd.Connection = con;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    StdName = dr["StudentName"].ToString();
                    FathName = dr["FatherName"].ToString();
                    Prg = dr["Program"].ToString();
                    GRNum = dr["GR.No"].ToString();
                        

                }
            }
            catch (Exception exc)
            { MessageBox.Show(exc.Message); }
            
            con = new SqlConnection(@"Data Source=HP\SQLEXPRESS1;Initial Catalog=testdb1;Integrated Security=True");
            ds = new DataSet();
            string cmnd = ("SELECT * FROM Reciept ");
            da = new SqlDataAdapter(cmnd, con);
            con.Open();
            da.Fill(ds, "Reciept");
            MaxRows = ds.Tables["Reciept"].Rows.Count;
            Navigation1();

            con.Close();
            //cmd = new SqlCommand("SELECT * FROM Reciept WHERE SlipNumber='" +tempForRecieptNo + "'", con);
            //cmd.Connection = con;

            //try
            //{
            //    con.Open();
            //    dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        RecieptNum = dr.GetString(0);
            //        SubjectOfFee=dr.GetString(2);
            //        PaymentDate = dr.GetString(4);
            //        FeeText = (dr.GetString(3));
                    
            //    }
            //}
            //catch (Exception exc) { MessageBox.Show(exc.Message); }
           // RecieptNoText.Text = RecieptNum;
            //StudentNameText.Text = StdName;
            //FatherNameText.Text = FathName;
            //GRNoText.Text = TempForRollNo;
            //ProgrammeText.Text = Prg;
            //DateText.Text = PaymentDate;
            //RecieptNoText.Text = RecieptNum;
           
            
            
           
        }
        public void RightSideKPangy()
        {
            AdmissionFeeText.Text = "0";
            SecurityDepositText.Text = "0";
            MonthlyFeeText.Text = "0";
            CertificateFeeText.Text = "0";
            ExamFeeText.Text = "0";
            TotalText.Text = "0";
             
            if (SubjectOfFee == "Admission Fee")
            { AdmissionFeeText.Text = FeeText;
            TotalText.Text = FeeText;
            }
            else if (SubjectOfFee == "Examination Fee")
            { ExamFeeText.Text = FeeText;
            TotalText.Text = FeeText;
            }
            else if (SubjectOfFee == "Security Deposit")
            { SecurityDepositText.Text = FeeText;
            TotalText.Text = FeeText;
            }
            else if (SubjectOfFee == "Certificate Fee")
            {
                CertificateFeeText.Text = FeeText;
                TotalText.Text = FeeText;
            }
            else if ((SubjectOfFee == "1st Month Fee") || (SubjectOfFee == "2nd Month Fee") || (SubjectOfFee == "3rd Month Fee") || (SubjectOfFee == "4th Month Fee") || (SubjectOfFee == "4th Month Fee") || (SubjectOfFee == "5th Month Fee") || (SubjectOfFee == "6th Month Fee") || (SubjectOfFee == "7th Month Fee") || (SubjectOfFee == "8th Month Fee") || (SubjectOfFee == "9th Month Fee") || (SubjectOfFee == "10th Month Fee") || (SubjectOfFee == "11th Month Fee") || (SubjectOfFee == "12th Month Fee") || (SubjectOfFee == "13th Month Fee") || (SubjectOfFee == "14th Month Fee") || (SubjectOfFee == "15th Month Fee") || (SubjectOfFee == "16th Month Fee") || (SubjectOfFee == "17th Month Fee") || (SubjectOfFee == "18th Month Fee") || (SubjectOfFee == "19th Month Fee") || (SubjectOfFee == "20th Month Fee") || (SubjectOfFee == "21st Month Fee") || (SubjectOfFee == "22nd Month Fee") || (SubjectOfFee == "23rd Month Fee") || (SubjectOfFee == "24th Month Fee"))
            { MonthlyFeeText.Text = FeeText;
            TotalText.Text = FeeText;
            }
 
        }
       
        public void Navigation1()
        {

            DataRow drow = ds.Tables["Reciept"].Rows[MaxRows-1];
            RecieptNum = drow.ItemArray.GetValue(0).ToString();
            SubjectOfFee=drow.ItemArray.GetValue(2).ToString();
            PaymentDate = drow.ItemArray.GetValue(4).ToString();
            FeeText =drow.ItemArray.GetValue(3).ToString();
            
        }
        private void FormPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testdb1DataSet1.Registration' table. You can move, or remove it, as needed.
           // this.registrationTableAdapter.Fill(this.testdb1DataSet1.Registration);

            StudentNameText.Text = StdName;
            FatherNameText.Text = FathName;
            GRNoText.Text = TempForRollNo;
            ProgrammeText.Text = Prg;
            DateText.Text = PaymentDate;
            RecieptNoText.Text = RecieptNum;
            MonthlyFee.Text = ("Tution Fee\n(" + DateTime.Now.ToString("Y")+")");
            RightSideKPangy();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormFee().Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);


        }
        Bitmap bmp;

        private void button2_Click(object sender, EventArgs e)
        {
            int width=769-40;
            int hieght=571-40;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(width ,hieght,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen((this.Location.X)+10,(this.Location.Y)+35,30,50,this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
